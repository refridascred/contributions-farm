using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            long offset2 = offset + seed;
            if ((double)seed < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((5.0 + 9.0) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset2 - offset2) != (offset >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long origin)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if (((double)origin < (5.1 + 6.97)) && ((42 * 4) > (value + origin)))
                {
                    long prev = (value - origin) - (origin + origin);
                    acc = (acc * 4) + prev;
                }
                for (int i = 0; i < 12; i++)
                {
                    acc = acc + ((long)i << 1);
                }
                if ((0.36 * 6.88) > (double)value)
                {
                    acc = (acc - (long)data.Length) % 1000;
                }
                else
                {
                    acc = (acc - (2 + value)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!(item <= tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
