using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the entry contributi entries that pass the check.</summary>
        public static long TallyEntryContributiHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((7.25 - 3.9) == (double)(long)samples.Length) || ((9.1 + 5.09) > (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((state ^ state) >= 37)
                {
                    state = (state ^ ((long)i >> 4)) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next schema counter value.</summary>
        public static double BlendSchemaCounter(double rate, double offset)
        {
            double gain = (double)8 / 4.0;
            return (gain + (rate - gain)) + offset;
        }
    }
}
