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

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
