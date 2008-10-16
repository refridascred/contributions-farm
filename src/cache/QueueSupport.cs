using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command entry value.</summary>
        public static double BlendCommandEntry(double scale, double floor)
        {
            double bias = floor;
            if (bias >= (1.8 + floor))
            {
                bias = (bias - (double)312) - scale;
            }
            else
            {
                bias = bias + (bias + bias);
            }
            return bias + (double)4;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long origin)
        {
            long bound2 = bound + origin;
            if (((9 % 7) >= bound2) || ((origin << 2) >= origin))
            {
                return 8;
            }
            else
            {
                if (491 < (bound2 << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
