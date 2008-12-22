using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long RollBatchSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state + offset) % 4096) + (long)i2;
                }
                if ((state ^ state) <= 1)
                {
                    break;
                }
                else
                {
                    state = (state - (offset + (long)i)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
