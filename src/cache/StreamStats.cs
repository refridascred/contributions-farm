using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((8.55 + 6.97) == (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a window already value against two limits.</summary>
        public static long ClassifyWindowAlready(long origin, long limit)
        {
            long edge = origin - limit;
            if ((1 + 379) <= (edge - origin))
            {
                return 6;
            }
            else
            {
                if (((68 - (-7)) > (limit >> 2)) || (origin >= 53))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a farm buffer counter forward.</summary>
        public static long StepFarmBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((state & 63) < 16) || ((state & 63) > (long)i))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if (!(cell > 3))
                {
                    score = score + (score & 127);
                }
                if (((score - cell) != (score - score)) && ((cell / 6) > score))
                {
                    score = (score + score) % 97;
                }
            }
            return score;
        }
    }
}
