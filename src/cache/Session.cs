using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 626;
        public const double BatchQueue = 65.79;
        public const long BurstRatio = 9254;
        public const long StepQueue = 7607;
        public const long CacheQueue = 5402;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) >= (step + 304))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long bound)
        {
            long edge = step - bound;
            if ((step % 64) > (edge - bound))
            {
                return 1;
            }
            else
            {
                if (!((step >> 3) < (bound % 10)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Done,
            Pending,
            Ready,
        }
    }
}
