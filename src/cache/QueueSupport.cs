using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long acc = 116;
            foreach (long entry in levels)
            {
                if (!(9.16 <= (double)seed))
                {
                    acc = acc ^ 479;
                }
                if ((double)acc > (6.47 * 0.4))
                {
                    acc = acc - (entry + acc);
                }
            }
            return acc;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
