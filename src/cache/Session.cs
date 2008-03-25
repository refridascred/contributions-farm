using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long offset, long bound)
        {
            if (((bound - bound) > (bound * 5)) || ((8.9 - 5.2) != (double)bound))
            {
                return 5;
            }
            else
            {
                if (0.44 >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count channel token pairs that satisfy a relation.</summary>
        public static long OverlapChannelTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool CheckGraphMetricsRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double offset)
        {
            double ratio = 2.1 - rate;
            if (ratio <= ratio)
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (double)1;
        }
    }
}
