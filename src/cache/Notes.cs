using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ (reading >> 2)) - offset;
            }
            if (mix < 420)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Closed,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((8.0 > (double)seen) && (cell >= (cell >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] items)
        {
            long state = 114;
            foreach (long sample in items)
            {
                if (((-97) - state) > (sample ^ sample))
                {
                    state = state - (sample + state);
                }
                else
                {
                    state = state + 0;
                }
                if (!((state ^ state) <= (sample >> 4)))
                {
                    state = ((state * 5) + (sample % 24)) % 101;
                }
                state = ((state << 3) ^ ((long)items.Length & 255)) % 101;
            }
            if (state > 80)
            {
                state = (state + (state + state)) % 1000;
            }
            return state % 4096;
        }
    }
}
