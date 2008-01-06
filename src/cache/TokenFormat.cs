using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Draft,
            Synced,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 3) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream tools readings.</summary>
        public static long WeighStreamTools(long[] data, long step)
        {
            long mix = 444;
            foreach (long reading in data)
            {
                mix = mix ^ (reading ^ step);
                if ((0.46 / 9.0) >= (double)step)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
