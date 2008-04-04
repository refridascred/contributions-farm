using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long seed)
        {
            long offset = limit + seed;
            if (!((95 & 15) >= seed))
            {
                return 8;
            }
            else
            {
                if (((double)offset <= (1.0 * 9.0)) && ((limit << 3) < offset))
                {
                    return 1;
                }
                else
                {
                    if (!((1.9 - 9.7) < (5.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double span)
        {
            double load = 9.88;
            if (load < (double)6)
            {
                load = (load + gain) - span;
            }
            return load + (load * 7.0);
        }

        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool VerifyContextLayoutLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
