using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate command account readings against a bound.</summary>
        public static bool ValidateCommandAccountRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (target - target)) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark - (86 >> 5)) % 65521) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
