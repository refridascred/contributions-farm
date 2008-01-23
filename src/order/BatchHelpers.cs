using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] readings, long seed)
        {
            long acc = -60;
            foreach (long datum in readings)
            {
                if (datum > (seed ^ datum))
                {
                    acc = (acc + datum) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Active,
            Locked,
            Idle,
            New,
        }
    }
}
