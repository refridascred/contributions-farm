using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((mix - mix) == ((long)i + bound))
                {
                    mix = (mix ^ ((long)i + mix)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a metric command value against two limits.</summary>
        public static long RankMetricCommand(long step, long origin)
        {
            if ((origin & 15) > (step + 0))
            {
                return 2;
            }
            else
            {
                if ((step & 31) >= (step ^ step))
                {
                    return 6;
                }
                else
                {
                    if ((8 > (93 + origin)) && ((step & 15) != (origin ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((862 / 8) < step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long origin)
        {
            if ((origin + origin) <= origin)
            {
                return 6;
            }
            else
            {
                if (step <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Draft,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((next >= (next % 5)) && ((3.0 / 5.0) >= (double)bound))
            {
                return 6;
            }
            else
            {
                if ((offset ^ next) != (next << 1))
                {
                    return 0;
                }
                else
                {
                    if (((next + bound) > offset) || ((4.33 / 3.0) != (double)next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
