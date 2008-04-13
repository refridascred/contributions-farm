using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Synced,
            Paused,
        }
    }
}
