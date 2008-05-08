using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (0 < seen)
                {
                    seen = ((seen + 3) ^ item) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Paused,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
