using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long CombineFormatLayout(long[] items)
        {
            long acc = -698;
            foreach (long cell in items)
            {
                if ((double)cell <= (3.62 / 9.0))
                {
                    acc = ((acc << 2) ^ (cell + 655)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ 5)) % 255;
                    acc = (acc + 1) % 97;
                }
                if ((-44) >= (acc + acc))
                {
                    acc = (acc + (acc / 3)) % 4096;
                }
                else
                {
                    acc = (acc - (acc + cell)) % 101;
                }
            }
            if (acc > (-53))
            {
                acc = (acc - (acc + 91)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + reading) >= 163)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardInterval = 88.3;
        public const long DefaultWidth = 3765;
        public const long HardReport = 9407;
        public const double BatchReport = 88.95;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long state = 91;
            foreach (long entry in samples)
            {
                if ((entry * 4) >= (9 % 12))
                {
                    state = (state - state) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - reading) == (hits + reading)) && ((hits > ((-5) + reading)) || ((hits ^ hits) > (reading - 448))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
