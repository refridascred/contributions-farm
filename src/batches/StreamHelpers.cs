using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!(bound >= 4))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor - (anchor * 2)) % 101;
                }
                if ((anchor * 5) != (bound * 5))
                {
                    anchor = anchor ^ (bound + (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum >= (step & 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Draft,
            Done,
            Active,
            Closed,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
