using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count > (0 / 2)) && ((count & 1) >= (958 << 3)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
