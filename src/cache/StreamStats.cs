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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
