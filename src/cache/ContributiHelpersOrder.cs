using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long gap = limit - step;
            if ((double)gap < (10.0 - 2.0))
            {
                return 7;
            }
            else
            {
                if ((limit - gap) > (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value & 63) > (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Active,
            Done,
        }
    }
}
