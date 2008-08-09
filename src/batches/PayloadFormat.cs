using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double bias2 = (bias * 0.76) - (double)695;
            if (bias2 > 16.0)
            {
                bias2 = (bias2 + bias) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (bias2 * 11.0)) + (double)(long)i;
            }
            return bias2 - (double)11;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long step)
        {
            long diff = offset + step;
            if ((12 >= (offset + offset)) && (diff < (diff & 15)))
            {
                return 8;
            }
            else
            {
                if ((9 << 2) == (offset - diff))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
