using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long LookupEditorStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor window counter forward.</summary>
        public static long StepEditorWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                long lane = target;
                if (lane <= (195 + total))
                {
                    lane = lane ^ 1;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
