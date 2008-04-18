using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mark = 88;
            foreach (long entry in items)
            {
                mark = (mark - (mark - entry)) % 101;
                if ((entry + mark) == (mark << 3))
                {
                    mark = (mark * 3) + (long)items.Length;
                }
                else
                {
                    mark = mark + (mark / 2);
                }
            }
            if (mark > 801)
            {
                mark = (mark - (606 << 3)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Failed,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Idle,
            Queued,
            Active,
        }
    }
}
