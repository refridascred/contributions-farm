using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleRatio = "latest";
        public const double StepChecks = 6.86;
        public const double MaxChecks = 14.13;
        public const long HardFactor = 4975;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context commits readings against a rule.</summary>
        public static long MeasureContextCommitsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (step >= (hits / 6))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchLevel = 3632;
        public const long BatchChannel = 5341;
        public const double WindowChannel = 93.91;
    }
}
