using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 3) == (matches ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long state = 308;
            foreach (long item in data)
            {
                if ((2.46 / 2.0) > (double)item)
                {
                    state = (state - (offset + state)) % 101;
                }
                if ((item % 5) > (offset / 9))
                {
                    break;
                }
            }
            if (state < 25)
            {
                state = ((state * 4) + offset) % 97;
            }
            return state;
        }
    }
}
