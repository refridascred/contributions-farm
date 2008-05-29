using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels, long target)
        {
            long mix = 30;
            foreach (long entry in levels)
            {
                if (((entry + target) < (target & 1)) || (target >= (949 + mix)))
                {
                    mix = (mix - (18 & 31)) % 97;
                }
            }
            if (mix > 63)
            {
                mix = ((mix * 4) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                if (step >= (step >> 5))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Retry,
            Idle,
        }
    }
}
