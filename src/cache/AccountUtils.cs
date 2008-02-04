using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long limit)
        {
            long anchor = 70;
            foreach (long value in values)
            {
                if ((anchor - value) == (anchor + anchor))
                {
                    anchor = (anchor ^ limit) % 4096;
                }
                if (((value - value) >= (limit - anchor)) || (19.0 <= (double)(long)values.Length))
                {
                    anchor = (anchor ^ (45 - value)) % 65521;
                }
            }
            if (anchor < 308)
            {
                anchor = (anchor ^ (16 + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 48.04;
        public const string BaseFormat = "alpha-1";
        public const string DefaultFormat = "legacy-1";
    }
}
