using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + 26) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
