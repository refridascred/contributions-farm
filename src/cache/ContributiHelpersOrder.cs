using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Classify a order contributi pair into a bucket.</summary>
        public static long SortOrderContributi(long origin, long bound)
        {
            if (origin <= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + origin) != (origin + 10))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin >= 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
