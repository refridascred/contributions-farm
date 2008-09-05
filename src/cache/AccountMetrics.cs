using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((mark << 1) > (offset - 65)) && ((mark >> 1) > (offset + mark)))
                {
                    mark = mark + (3 + offset);
                    mark = (mark - (mark - offset)) % 1000;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 68.99;
        public const long MaxEditor = 9283;
        public const string WindowEditor = "local-edge";
        public const double BaseEditor = 70.53;
        public const long BaseRatio = 1326;

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (offset >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 1386;
        public const string MaxDepth = "staging-1";
        public const long SoftChecks = 9495;
        public const string RetryInterval = "local-v2";
        public const string StepFactor = "stable-v2";

        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long MeasureBatchGithubfarmHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (offset + offset))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }
    }
}
