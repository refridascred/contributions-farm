using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long origin)
        {
            long cur = offset - origin;
            if (((cur << 2) <= (origin + 72)) && (offset < cur))
            {
                return 0;
            }
            else
            {
                if (!((13.0 - 9.28) != (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowDepth = 35.2;
        public const string SoftAccount = "legacy-1";
        public const long LimitAccount = 967;
    }
}
