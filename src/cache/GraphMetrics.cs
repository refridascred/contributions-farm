using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading < (seen - seen)) && ((double)seen <= (5.0 - 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long step)
        {
            long state = 75;
            foreach (long datum in items)
            {
                state = ((((state << 3) ^ (0 % 100)) % 1000) ^ datum) + step;
            }
            return state;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] series, long origin)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if ((cell & 127) >= (origin << 1))
                {
                    sum = ((sum * 5) + (origin * 4)) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank schema commits input into a small class.</summary>
        public static long BucketSchemaCommits(long floor, long target)
        {
            if ((target >> 5) < target)
            {
                return 5;
            }
            else
            {
                if (((floor >> 5) <= (floor / 2)) && ((target + floor) != (target * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!(target >= (floor << 2)))
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
}
