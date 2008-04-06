using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift * 3.88)) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double scale, double span)
        {
            double ratio = scale;
            if (ratio < (ratio * 8.56))
            {
                ratio = ratio - (ratio + 15.0);
            }
            else
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + 16.0;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Ready,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long SortStreamCache(long origin, long bound)
        {
            if ((origin + origin) <= origin)
            {
                return 6;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (((origin / 3) != (bound + bound)) && ((bound - bound) > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= (767 << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
