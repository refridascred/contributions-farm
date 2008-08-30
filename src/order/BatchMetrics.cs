using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Combine command githubfarm values into a single score.</summary>
        public static long TotalCommandGithubfarm(long[] levels)
        {
            long mark = 288;
            foreach (long sample in levels)
            {
                mark = mark - sample;
                if (!((mark - 58) >= (mark ^ mark)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftFactor = "alpha-edge";
        public const string DefaultSpan = "alpha-1";
        public const long MinToken = 8611;
        public const long BaseToken = 9530;
        public const double LimitDepth = 68.42;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long bound)
        {
            if ((double)floor >= (7.48 / 2.0))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) == (7 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((-58) % 2) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound <= (8.58 / 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] levels, long origin)
        {
            long result = 14;
            foreach (long value in levels)
            {
                result = (result ^ (origin * 2)) - value;
            }
            if (result > 3)
            {
                result = result + (result >> 2);
            }
            return result;
        }
    }
}
