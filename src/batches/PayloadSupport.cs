using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long seed)
        {
            if ((738 >> 1) >= seed)
            {
                return 5;
            }
            else
            {
                if (((7.1 - 0.19) < (double)seed) || (seed >= (step * 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Done,
            Paused,
            Queued,
            Stale,
        }
    }
}
