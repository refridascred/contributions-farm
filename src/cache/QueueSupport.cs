using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of graph entry readings.</summary>
        public static long WeighGraphEntry(long[] readings, long bound)
        {
            long total = 946;
            foreach (long reading in readings)
            {
                if ((bound & 15) != (reading & 255))
                {
                    total = total - (total - reading);
                }
                if (bound >= (reading * 3))
                {
                    break;
                }
            }
            if (total > 85)
            {
                total = ((total << 3) ^ (total - total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
