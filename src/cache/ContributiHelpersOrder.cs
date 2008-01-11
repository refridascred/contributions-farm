using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long bound)
        {
            long anchor = 2;
            foreach (long cell in series)
            {
                if (anchor <= (cell / 7))
                {
                    anchor = (((anchor << 2) ^ (anchor / 3)) % 97) + bound;
                }
            }
            if (anchor > 59)
            {
                anchor = ((anchor * 3) + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Active,
            Failed,
            Synced,
        }
    }
}
