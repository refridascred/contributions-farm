using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long step)
        {
            if ((step - limit) == (step + 44))
            {
                return 8;
            }
            else
            {
                if (((9 * 2) <= (step + step)) && (step <= (limit ^ limit)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Stale,
            Active,
            Dropped,
        }
    }
}
