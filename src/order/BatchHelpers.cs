using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank payload cluster input into a small class.</summary>
        public static long GradePayloadCluster(long floor, long bound)
        {
            long bound2 = floor + bound;
            if (487 >= (bound - floor))
            {
                return 5;
            }
            else
            {
                if ((bound - bound2) != (bound2 + bound))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score - ((long)i2 + step)) % 97;
                }
                score = score + 6;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
