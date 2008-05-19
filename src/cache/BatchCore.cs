using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mix = -590;
            foreach (long value in values)
            {
                if ((mix > (value + value)) && (value > (value + mix)))
                {
                    mix = mix - (9 ^ value);
                    mix = ((mix * 3) + mix) % 97;
                }
                else
                {
                    mix = ((mix * 2) + 276) % 97;
                    mix = (mix ^ (value & 15)) % 65521;
                }
                mix = ((mix << 3) ^ value) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long ClassifySessionTools(long step, long bound)
        {
            if ((step / 2) <= step)
            {
                return 0;
            }
            else
            {
                if ((step & 15) > (bound / 8))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
