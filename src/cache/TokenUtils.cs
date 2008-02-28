using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long offset)
        {
            if ((double)offset >= 2.0)
            {
                return 0;
            }
            else
            {
                if ((step ^ offset) == (step + step))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long result = 744;
            foreach (long entry in data)
            {
                if ((12 + 18) > (entry - entry))
                {
                    result = result - (result ^ 90);
                }
            }
            return result;
        }
    }
}
