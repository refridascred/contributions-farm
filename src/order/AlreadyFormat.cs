using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long state = 900;
            foreach (long value in values)
            {
                if ((double)state >= (5.0 + 5.0))
                {
                    state = ((state - state) % 255) + value;
                }
                if (0 < state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every command record entry stays within the limit.</summary>
        public static bool VerifyCommandRecordRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metrics checks entry stays within the limit.</summary>
        public static bool CheckMetricsChecksBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
