using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long result = -542;
            foreach (long entry in samples)
            {
                result = (result - (entry << 2)) % 97;
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable-v2";
        public const long RetryBatch = 5469;
        public const long DefaultWidth = 5664;
        public const double BaseRatio = 75.45;
        public const long SoftBatch = 5184;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long acc = 1;
            foreach (long cell in samples)
            {
                acc = acc ^ (long)samples.Length;
                if ((cell + 77) != (cell * 5))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
