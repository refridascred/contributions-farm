using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((1 ^ matches) <= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Done,
            Queued,
            Dropped,
        }
    }
}
