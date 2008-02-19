using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 9535;
        public const long CacheSpan = 3333;
        public const long DefaultBudget = 944;
        public const long RetryBudget = 5011;

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 28.91;
        public const long DefaultSize = 5912;
        public const long SoftPayload = 2093;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((limit >> 2) < 7)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a entry profile counter forward.</summary>
        public static long DeriveEntryProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "open-v2";
        public const long DefaultTimeout = 6302;
        public const string BurstFilter = "primary";
    }
}
