using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Active,
            New,
            Draft,
            Failed,
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long step2)
        {
            long span = step ^ step2;
            if ((64 - span) > (step2 % 10))
            {
                return 4;
            }
            else
            {
                if ((span << 1) < step2)
                {
                    return 8;
                }
                else
                {
                    if ((step2 + step2) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span % 2) < step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long step)
        {
            long cur = seed - step;
            if ((cur & 255) <= (cur - cur))
            {
                return 8;
            }
            else
            {
                if (seed >= (step / 4))
                {
                    return 6;
                }
                else
                {
                    if ((cur / 9) > cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur >= (step + 433))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a checks metrics reading.</summary>
        public static double SmoothChecksMetrics(double bias, double floor)
        {
            double gain = (double)(516 - (-9));
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias) + (double)(long)i) + floor;
            }
            return gain + gain;
        }
    }
}
