using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
