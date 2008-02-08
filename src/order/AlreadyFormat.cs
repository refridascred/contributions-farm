using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a notes profile reading.</summary>
        public static double AdjustNotesProfile(double rate, double offset)
        {
            double load = 17.0 * 3.0;
            if (load < (offset / 8.0))
            {
                load = load - rate;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (1.39 / 2.0)) - (double)(long)i;
            }
            return load - (load - 18.0);
        }

        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                long slot = (state - state) + (state + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 3) ^ (slot / 7)) % 97) ^ (long)i2;
                }
                slot = (slot << 3) ^ (state / 2);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + 0) == (sample + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = 9;
            foreach (long item in values)
            {
                result = (result ^ result) - item;
            }
            if (result < 4)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Active,
            Closed,
            Dropped,
            Synced,
        }
    }
}
