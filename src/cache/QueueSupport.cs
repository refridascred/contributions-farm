using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                if ((mix ^ 75) != ((long)i + (long)i))
                {
                    mix = (mix ^ mix) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
