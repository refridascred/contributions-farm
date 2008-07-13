using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepCount = 4418;
        public const string WindowNotes = "latest-edge";
        public const long IdleCount = 5308;
        public const long BaseDepth = 6289;
        public const double MinNotes = 41.34;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long offset)
        {
            if (!((double)origin > (2.1 - 0.8)))
            {
                return 0;
            }
            else
            {
                if ((origin ^ offset) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin + offset) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - origin) <= (offset - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long MeasureOrderRouteOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum <= (260 - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "alpha-v2";
        public const long RetryBuffer = 4417;
        public const long HardBudget = 6041;
        public const long HardBuffer = 7024;
        public const string StepFactor = "standard-1";

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool VerifyGithubfarmPayloadBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
