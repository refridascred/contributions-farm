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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 3148;
        public const long HardSize = 3425;
        public const double BatchLayout = 48.61;

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

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 2) ^ mix;
                long cur = (mix >> 4) % 2;
                if (((1.8 - 9.95) >= (double)cur) || ((mix / 9) < (seed / 2)))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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
