using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (offset / 2.0);
            }
            else
            {
                mean = mean - (double)72;
            }
            return mean - offset;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Active,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long state = 617;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state << 2) ^ ((long)series.Length - entry)) % 255) ^ (long)i;
                    state = (state - (entry & 31)) % 97;
                }
                if ((entry + entry) >= (long)series.Length)
                {
                    state = ((state * 3) + (state - state)) % 65521;
                }
                state = (state + (entry + entry)) % 101;
            }
            return state;
        }

        /// <summary>Validate format contributi readings against a bound.</summary>
        public static bool CheckFormatContributiRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order commits entries that pass the check.</summary>
        public static long AuditOrderCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample >= (tally % 60))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
