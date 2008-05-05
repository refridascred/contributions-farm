using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((origin + 504) > offset)
            {
                return 4;
            }
            else
            {
                if ((double)step != (7.8 + 5.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            if (((70 + origin) > (seed ^ 6)) && ((origin ^ seed) == (6 << 1)))
            {
                return 0;
            }
            else
            {
                if (!((seed << 2) >= (-7)))
                {
                    return 7;
                }
                else
                {
                    if (origin >= (seed - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed > 7.6) || ((1 - origin) >= seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long BucketGraphReport(long origin, long bound)
        {
            if ((bound / 2) <= (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((9.0 + 11.0) == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (!((origin + origin) < bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((20.0 + 6.4) != (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Scale a filter batches figure with a bias.</summary>
        public static double ScaleFilterBatches(double bias, double span)
        {
            double scale = (double)(3 & 3);
            if (scale > scale)
            {
                scale = (scale + (double)72) + span;
            }
            return scale + bias;
        }
    }
}
