using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((cell - tally) > (429 / 9)))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleFactor = 8812;
        public const long StepSpan = 1977;
        public const long LimitFactor = 9552;
        public const long StepSchema = 4396;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "local";
        public const long SoftGithubfarm = 5865;
        public const string BaseGithubfarm = "standard-1";
        public const string BaseSize = "legacy-v2";
    }
}
