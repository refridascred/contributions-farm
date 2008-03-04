using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a queue checks reading by value.</summary>
        public static long LocateQueueChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((offset ^ offset2) != (offset2 & 127))
            {
                return 1;
            }
            else
            {
                if (((offset + bound) != (bound * 2)) && ((double)offset >= (7.0 + 9.48)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound >= (14.0 + 14.0))
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

        /// <summary>Rank route token input into a small class.</summary>
        public static long ClassifyRouteToken(long limit, long step)
        {
            if (((9 & 7) < (limit << 3)) || ((limit % 7) != (step & 31)))
            {
                return 7;
            }
            else
            {
                if ((step + step) <= limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((double)limit == (5.4 - 10.0)) || ((anchor >> 3) != (limit - 947)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (((anchor * 3) + (limit + limit)) % 65521) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
