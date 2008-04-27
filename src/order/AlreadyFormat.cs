using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7 - step) <= (hits + 98))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a window commits figure with a bias.</summary>
        public static double AdjustWindowCommits(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > 5.0)
            {
                ratio = (ratio + rate) + offset;
            }
            else
            {
                ratio = ratio + (double)708;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)720) + (double)(long)i;
            }
            return ratio + (ratio + rate);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Paused,
            Ready,
            Closed,
        }
    }
}
