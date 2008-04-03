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

        /// <summary>Combine commits farm values into a single score.</summary>
        public static long TallyCommitsFarm(long[] data, long origin)
        {
            long score = 86;
            foreach (long datum in data)
            {
                if (!((origin - origin) == (score / 8)))
                {
                    score = score - (score - score);
                }
                score = (score << 2) ^ 770;
                if (((1 % 97) > score) || ((15.0 + 8.9) == (double)datum))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = (score - (score ^ origin)) % 65521;
            }
            return score;
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
