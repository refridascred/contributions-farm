using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double load = weight;
            if (load >= (load - span))
            {
                load = load + load;
            }
            else
            {
                load = load + (double)37;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (span + 8.0)) + (double)(long)i;
            }
            return load - (weight + weight);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((seed & 7) < (lane - bound))
            {
                return 8;
            }
            else
            {
                if ((402 + bound) > (seed << 3))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (9.1 / 8.0)) || ((double)bound <= (double)5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane ^ bound) >= lane)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double load = bias;
            if (load > (double)964)
            {
                load = (load + load) + span;
            }
            return load - (bias / 7.0);
        }
    }
}
