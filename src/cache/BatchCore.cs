using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                long lane = (long)i;
                lane = (lane * 4) + (lane / 2);
                if ((54 <= (94 + lane)) && (acc <= (lane & 15)))
                {
                    lane = (lane ^ (origin % 10)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
