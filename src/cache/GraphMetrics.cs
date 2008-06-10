using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Draft,
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long SortContextGraph(long offset, long origin)
        {
            long lane = offset - origin;
            if ((lane << 3) != (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if ((6.6 / 4.0) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (lane >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data, long bound)
        {
            long mark = 82;
            foreach (long sample in data)
            {
                mark = (mark ^ mark) % 101;
                if (((mark * 3) <= bound) && ((bound << 3) < (sample >> 1)))
                {
                    mark = mark + (5 >> 1);
                }
                if (!(((-25) % 8) == (sample / 6)))
                {
                    break;
                }
            }
            if (mark < 83)
            {
                mark = (mark + ((long)data.Length << 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
