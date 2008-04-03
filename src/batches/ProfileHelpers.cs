using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((7.5 - 7.7) != (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double drift = scale;
            return (drift + (drift / 2.0)) + span;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
