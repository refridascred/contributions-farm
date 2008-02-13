using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long total = 69;
            foreach (long reading in samples)
            {
                if (((double)total >= (8.4 - 19.0)) && ((total & 127) == (total / 8)))
                {
                    total = ((total ^ (79 + 26)) % 4096) + reading;
                }
            }
            if (total > 37)
            {
                total = (total << 3) ^ (total + 53);
            }
            return total;
        }

        /// <summary>Rank buffer filter input into a small class.</summary>
        public static long ClassifyBufferFilter(long limit, long step)
        {
            long span = limit - step;
            if ((span - step) < (118 / 7))
            {
                return 6;
            }
            else
            {
                if ((step + 1) < step)
                {
                    return 0;
                }
                else
                {
                    if (((407 ^ span) <= (99 / 2)) && ((limit / 3) != (limit + span)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5 * 5) > (span / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items, long origin)
        {
            long carry = 85;
            foreach (long datum in items)
            {
                if ((5 + origin) < (datum ^ origin))
                {
                    carry = (carry << 2) ^ (carry / 6);
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long limit)
        {
            long edge = step + limit;
            if ((limit >> 4) > (edge >> 3))
            {
                return 4;
            }
            else
            {
                if ((limit / 2) < (step - edge))
                {
                    return 2;
                }
                else
                {
                    if (((double)edge != (12.0 * 8.7)) && ((limit % 16) <= (3 % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report metric readings.</summary>
        public static long MatchReportMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
