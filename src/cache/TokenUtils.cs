using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Queued,
            New,
            Paused,
        }

        /// <summary>Rank cache record input into a small class.</summary>
        public static long ClassifyCacheRecord(long offset, long step)
        {
            long prev = offset - step;
            if (!(68 >= (prev - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset & 31) <= (step % 60))
                {
                    return 8;
                }
                else
                {
                    if ((43 << 3) < (step & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
