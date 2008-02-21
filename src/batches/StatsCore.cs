using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit support payload readings against a rule.</summary>
        public static long TallySupportPayloadOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((878 >= (reading % 3)) && ((seen % 12) <= (seen % 3)))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long floor)
        {
            long next = offset - floor;
            if ((double)next != (5.73 * 15.0))
            {
                return 6;
            }
            else
            {
                if ((5.62 / 5.0) <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (next >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch order pair into a bucket.</summary>
        public static long GradeBatchOrder(long origin, long target)
        {
            long prev = origin ^ target;
            if ((3.7 / 6.0) < (double)target)
            {
                return 3;
            }
            else
            {
                if (!((60 >> 3) < origin))
                {
                    return 8;
                }
                else
                {
                    if ((target > (57 + target)) && ((origin % 12) < (92 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev >> 5) >= (target + origin))
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

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long step2)
        {
            if (step2 > (87 * 4))
            {
                return 8;
            }
            else
            {
                if (!(step >= (step << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (8.52 * 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 2) == (step + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
