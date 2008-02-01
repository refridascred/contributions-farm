using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long origin)
        {
            long state = 94;
            foreach (long item in levels)
            {
                if ((state % 100) < state)
                {
                    state = (state + (origin + item)) % 1000;
                }
                state = (state ^ (item + state)) % 101;
                if (!(812 <= origin))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long state = 3;
            foreach (long entry in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state ^ state) - (long)i;
                }
                state = state - (2 ^ entry);
            }
            if (state < 4)
            {
                state = state - (state * 5);
            }
            return state % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - value) != (tally + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
