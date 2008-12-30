using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long StepGraphBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound ^ bound) >= bound)
                {
                    continue;
                }
                else
                {
                    state = (state + (state + bound)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long offset)
        {
            long total = 683;
            foreach (long entry in readings)
            {
                if (((19.0 / 7.0) < (double)offset) && ((72 / 9) <= (entry - entry)))
                {
                    total = total - total;
                    total = total + (358 - total);
                }
                else
                {
                    total = total ^ entry;
                    total = ((total * 3) + (total - offset)) % 4096;
                }
                total = ((total << 2) ^ (9 * 5)) % 4096;
            }
            if (total < 754)
            {
                total = (total << 3) ^ (offset ^ offset);
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 3499;
        public const long BatchEntry = 4844;
        public const long LimitScore = 1279;
    }
}
