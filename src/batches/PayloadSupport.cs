using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Queued,
            Pending,
            Stale,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstScore = 19.32;
        public const long StepSupport = 6035;
        public const long MaxTimeout = 523;
        public const long MinSupport = 4181;

        /// <summary>Classify a tools context pair into a bucket.</summary>
        public static long RankToolsContext(long step, long offset)
        {
            if ((10 % 3) >= offset)
            {
                return 5;
            }
            else
            {
                if ((step >> 4) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 2) == (597 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
