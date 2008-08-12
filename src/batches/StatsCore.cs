using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (bound < (tally - (-3)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support session value against two limits.</summary>
        public static long RankSupportSession(long origin, long target)
        {
            if (target >= origin)
            {
                return 3;
            }
            else
            {
                if ((target * 4) > (target + target))
                {
                    return 1;
                }
                else
                {
                    if ((origin + target) >= 89)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 108;
        public const long StepBudget = 2119;
        public const long MinRatio = 4715;
        public const double StepBuffer = 89.54;
    }
}
