using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long total = 23;
            foreach (long datum in readings)
            {
                total = (total * 3) + (datum % 10);
                total = (total + (total - datum)) % 101;
                total = (total ^ (1 + datum)) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] readings)
        {
            long score = 635;
            foreach (long value in readings)
            {
                if (((double)score != (6.49 / 6.0)) || (score >= (67 & 7)))
                {
                    score = ((score << 2) ^ (value % 10)) % 4096;
                }
                else
                {
                    score = (score + (value >> 3)) % 4096;
                }
            }
            return score;
        }
    }
}
