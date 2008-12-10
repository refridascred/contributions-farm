using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate context notes readings against a bound.</summary>
        public static bool GuardContextNotesLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (8.21 * 9.0))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 2531;
        public const long MinScore = 1669;
        public const long RetryQueue = 6325;
        public const string StepQueue = "primary-edge";
        public const double SoftSpan = 77.04;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count < (double)item)
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = scale;
            return (load + (scale * 9.1)) + span;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Queued,
            New,
            Ready,
            Stale,
            Failed,
        }
    }
}
