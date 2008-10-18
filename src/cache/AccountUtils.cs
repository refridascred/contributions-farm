using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long MeasureBatchesFarmMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seed >= (seed * 2))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                if ((sample * 5) == (sample + sample))
                {
                    result = ((result * 4) + result) % 101;
                }
                result = result - result;
                if (((result & 3) > (result * 5)) && (sample < (17 / 6)))
                {
                    result = (result * 2) + (result % 3);
                }
            }
            if (result > 55)
            {
                result = (result ^ (274 + result)) % 255;
            }
            return result;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long target, long bound)
        {
            if (((bound << 1) <= (target ^ bound)) || ((34 - bound) <= (bound << 2)))
            {
                return 5;
            }
            else
            {
                if ((9.41 * 3.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
