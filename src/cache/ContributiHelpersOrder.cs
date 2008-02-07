using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Weight { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
