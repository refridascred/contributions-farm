using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long floor)
        {
            if (0 > (floor % 2))
            {
                return 5;
            }
            else
            {
                if (75 > (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if (floor < (-629))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 / 6.0) > (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            if ((double)floor == (1.4 - 8.8))
            {
                return 3;
            }
            else
            {
                if ((floor - seed) <= (seed % 10))
                {
                    return 1;
                }
                else
                {
                    if ((19.0 - 9.0) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 5300;
        public const double MaxChannel = 63.18;
        public const double HardChannel = 2.71;
        public const long MinSize = 1341;
        public const long DefaultChannel = 9978;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool GuardGithubfarmCommandRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mix = 899;
            foreach (long item in series)
            {
                mix = (mix ^ mix) % 4096;
                if ((double)item < (double)843)
                {
                    mix = (mix + (item << 3)) % 65521;
                }
                if ((mix << 1) > (942 - 617))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
