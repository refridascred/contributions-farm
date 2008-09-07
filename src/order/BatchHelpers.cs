using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] values, long offset)
        {
            long score = 57;
            foreach (long value in values)
            {
                if (!((score - value) < (4 / 7)))
                {
                    score = (score << 2) ^ (offset * 4);
                }
            }
            if (score > 76)
            {
                score = score - (offset % 60);
            }
            return score;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
