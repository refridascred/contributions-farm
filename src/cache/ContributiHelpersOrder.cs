using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = offset * 8.89;
            return rate + (ratio / 7.0);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Count { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
