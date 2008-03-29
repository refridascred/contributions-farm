using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = mark - (long)i2;
                }
                if ((mark + (long)i) <= ((long)i ^ 732))
                {
                    mark = (mark << 2) ^ offset;
                    mark = (mark ^ (590 - offset)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (21 + mark);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long bound)
        {
            long diff = floor + bound;
            if (((15.0 + 14.0) <= (double)floor) || ((6 - bound) == (diff - diff)))
            {
                return 2;
            }
            else
            {
                if ((diff + bound) < diff)
                {
                    return 1;
                }
                else
                {
                    if (((floor - floor) == (4 << 3)) && ((floor << 3) == (floor / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.6 < (double)diff) || ((17.0 * 8.8) <= (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + seen) > sample)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
