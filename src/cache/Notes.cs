using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Idle,
            Failed,
            New,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total << 2) ^ 638;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
