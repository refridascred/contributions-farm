using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a queue session pair into a bucket.</summary>
        public static long ClassifyQueueSession(long seed, long step)
        {
            long bound = seed + step;
            if ((double)bound > (2.7 / 2.0))
            {
                return 3;
            }
            else
            {
                if (seed >= step)
                {
                    return 5;
                }
                else
                {
                    if ((206 >> 5) >= (step ^ step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed * 3) != (bound << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long step)
        {
            long result = 39;
            foreach (long reading in values)
            {
                result = (((result + result) % 97) ^ reading) - step;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (19.0 * 1.66)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
