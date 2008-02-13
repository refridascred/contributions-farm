using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Idle,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of stream profile readings.</summary>
        public static long WeighStreamProfile(long[] series, long bound)
        {
            long result = 1;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length != (1.0 / 8.0))
                {
                    result = ((result * 5) + datum) % 255;
                    break;
                }
                if ((430 * 3) < (bound ^ 42))
                {
                    result = (result * 2) + (bound >> 5);
                }
            }
            if (result < 8)
            {
                result = (result << 2) ^ (result - 286);
            }
            return result;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
