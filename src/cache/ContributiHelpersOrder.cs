using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                if (!((datum ^ datum) != (datum + mark)))
                {
                    mark = mark + 61;
                }
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Dropped,
            Stale,
        }
    }
}
