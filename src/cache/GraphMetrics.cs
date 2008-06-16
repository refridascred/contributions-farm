using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long floor)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!(entry < (entry & 3)))
                {
                    anchor = ((anchor ^ (entry >> 5)) % 65521) - floor;
                }
                if ((entry ^ entry) >= anchor)
                {
                    anchor = anchor ^ (816 * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ entry) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double rate = bias - 14.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long offset, long step)
        {
            if ((step % 2) < offset)
            {
                return 3;
            }
            else
            {
                if (step > ((-4) + step))
                {
                    return 0;
                }
                else
                {
                    if (offset > (step ^ 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((12.0 / 7.0) <= (double)offset)
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
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Failed,
            Draft,
        }
    }
}
