using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits == (double)limit)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] samples)
        {
            long state = 759;
            foreach (long item in samples)
            {
                state = ((state * 2) + item) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "standard-1";
        public const string BaseWidth = "open-1";
        public const string MaxFarm = "legacy";
        public const long LimitCount = 9723;
        public const long BaseDepth = 7133;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = 70;
            foreach (long datum in levels)
            {
                sum = ((sum + (54 & 127)) % 101) ^ datum;
                sum = (sum - (sum ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
