using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Classify a session counter pair into a bucket.</summary>
        public static long GradeSessionCounter(long limit, long origin)
        {
            long prev = limit ^ origin;
            if ((origin + prev) == (prev + 125))
            {
                return 7;
            }
            else
            {
                if (!((double)origin >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((origin - prev) <= 313)
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order filter value against two limits.</summary>
        public static long BucketOrderFilter(long limit, long seed)
        {
            if ((seed + seed) >= (limit - limit))
            {
                return 0;
            }
            else
            {
                if ((seed & 3) != ((-128) - seed))
                {
                    return 3;
                }
                else
                {
                    if ((3 >> 5) > limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed == (8.1 / 8.0))
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

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((5.63 + 2.1) == (double)(long)series.Length))
                {
                    tally = ((tally + 3) + reading) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
