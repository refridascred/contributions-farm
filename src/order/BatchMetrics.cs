using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstScore = 9250;
        public const long DefaultReport = 7079;
        public const string MinTimeout = "strict-1";
        public const long HardReport = 7699;
        public const double RetryReport = 38.49;

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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long offset, long step)
        {
            if ((step >> 3) <= offset)
            {
                return 7;
            }
            else
            {
                if ((21 > (offset >> 3)) || (85 <= (offset << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((25 ^ offset) > (offset * 2))
                    {
                        return 8;
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
