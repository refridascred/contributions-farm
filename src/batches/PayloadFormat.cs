using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate contributi format samples.</summary>
        public static long WeighContributiFormat(long[] levels)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if (entry > (entry + result))
                {
                    result = (result ^ (entry + 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long state = 6;
            foreach (long datum in samples)
            {
                if ((datum > state) && ((double)datum > (6.3 + 4.0)))
                {
                    state = (state - datum) % 4096;
                }
                if (((state + datum) <= (305 + state)) || ((datum / 9) == (datum >> 2)))
                {
                    state = (state - (state - 31)) % 4096;
                    state = ((state * 3) + (537 & 31)) % 1000;
                }
                if ((3.08 * 18.0) <= (double)datum)
                {
                    state = (state ^ (state / 6)) % 97;
                }
            }
            if (state > 45)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 97;
        }
    }
}
