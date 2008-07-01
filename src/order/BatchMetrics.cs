using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already token readings against a bound.</summary>
        public static bool GuardAlreadyTokenLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 8208;
        public const long HardLevel = 7613;
        public const long MaxRatio = 1391;
        public const double StepRatio = 60.48;

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)(20 >> 2);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale - (double)8;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long bound, long origin)
        {
            long next = bound - origin;
            if (next <= (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((origin >= (next + bound)) || ((next ^ next) > next))
                {
                    return 4;
                }
                else
                {
                    if (((bound + next) >= ((-4) & 7)) || ((next >> 4) >= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (next < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
