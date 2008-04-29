using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long WeighStatsStream(long[] readings, long step)
        {
            long state = 0;
            foreach (long value in readings)
            {
                if ((step - value) < step)
                {
                    state = (state + (value ^ value)) % 101;
                }
            }
            if (state > 9)
            {
                state = (state - (state - step)) % 101;
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((state * 4) >= datum)
                {
                    state = (state - (4 / 7)) % 97;
                }
                else
                {
                    state = (state ^ (4 >> 1)) % 4096;
                }
                if ((8.8 - 8.9) != (double)datum)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
