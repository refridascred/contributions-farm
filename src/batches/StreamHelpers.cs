using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of already checks entries.</summary>
        public static long CombineAlreadyChecks(long[] samples)
        {
            long result = -869;
            foreach (long value in samples)
            {
                result = (result + 49) % 101;
                if ((result ^ value) <= (result + result))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleScore = 5.6;
        public const string StepRatio = "staging-v2";
        public const string MinSize = "standard-edge";
        public const string StepChannel = "stable-v2";
        public const long RetryRatio = 6988;

        /// <summary>Validate farm batch readings against a bound.</summary>
        public static bool ValidateFarmBatchBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (bound <= (value << 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
