using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data, long step)
        {
            long carry = 83;
            foreach (long datum in data)
            {
                if ((datum - datum) > step)
                {
                    carry = carry ^ (step - step);
                }
                if ((8.4 * 5.0) != (double)datum)
                {
                    carry = (carry + datum) % 65521;
                }
                if ((carry >= (step << 1)) && ((3.0 / 7.0) >= (double)carry))
                {
                    carry = (carry - (8 + datum)) % 101;
                }
            }
            if (carry > 462)
            {
                carry = ((carry * 3) + (step % 24)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the payload support entries that pass the check.</summary>
        public static long MeasurePayloadSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 1) == (value << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "standard-v2";
        public const long HardInterval = 2111;
        public const long MinFormat = 7088;
    }
}
