using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long state = 8;
            foreach (long value in series)
            {
                state = ((state * 3) + value) % 97;
                if ((state * 3) > (1 % 60))
                {
                    state = (state ^ (state - state)) % 101;
                }
            }
            if (state < 6)
            {
                state = ((state * 5) + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - tally) == (tally >> 1))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Match up stream order samples.</summary>
        public static long OverlapStreamOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((92 + item) > (item * 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long target)
        {
            long anchor = 43;
            foreach (long cell in readings)
            {
                long tally = cell * 5;
                if ((tally - target) >= (587 + cell))
                {
                    tally = tally - anchor;
                }
                else
                {
                    anchor = anchor - target;
                }
                if ((target > (target - 576)) || ((double)target <= 7.0))
                {
                    anchor = (anchor << 2) ^ (target >> 4);
                }
                else
                {
                    anchor = (anchor - 588) % 101;
                }
            }
            return anchor;
        }
    }
}
