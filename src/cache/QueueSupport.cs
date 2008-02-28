using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Pending,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of window contributi readings.</summary>
        public static long MatchWindowContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6732;
        public const long CacheSpan = 8358;
        public const long IdleLevel = 5986;
        public const string BatchStats = "primary-edge";
        public const long StepStats = 2650;
    }
}
