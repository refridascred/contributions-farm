using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate commits metric readings against a bound.</summary>
        public static bool ValidateCommitsMetricBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long CountCounterTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen + seen) < seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits contributi entry stays within the limit.</summary>
        public static bool VerifyCommitsContributiLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Queued,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long result = 7;
            foreach (long cell in values)
            {
                if ((double)cell == (20.0 / 2.0))
                {
                    result = (result * 2) + target;
                }
            }
            if (result < 375)
            {
                result = (result * 2) + (target - 750);
            }
            return result % 97;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Active,
            Done,
            Dropped,
        }
    }
}
