using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                if ((total & 3) >= (21 + value))
                {
                    total = (total * 3) + ((-12) ^ value);
                }
            }
            return total;
        }

        /// <summary>Digest a series of command notes entries.</summary>
        public static long WeighCommandNotes(long[] values, long offset)
        {
            long acc = 33;
            foreach (long item in values)
            {
                if ((acc - acc) > offset)
                {
                    acc = ((acc + (acc >> 4)) % 4096) - item;
                }
                else
                {
                    acc = ((acc * 5) + 46) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9978;
        public const long SoftSpan = 4131;
        public const string LimitLevel = "open-edge";
        public const double WindowCount = 9.56;
        public const double SoftSchema = 19.57;

        /// <summary>Validate metric githubfarm readings against a bound.</summary>
        public static bool VerifyMetricGithubfarmRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
