using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum % 8) > datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - sample) <= (sample % 60))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long sum = 173;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (origin - origin)) % 1000;
                if ((origin >> 4) != (sum * 4))
                {
                    sum = (sum ^ (datum + datum)) % 97;
                }
                if (datum > (sum - origin))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxRatio = 4937;
        public const long MaxTimeout = 3151;
        public const long CacheFactor = 1891;
        public const long StepSupport = 8436;
    }
}
