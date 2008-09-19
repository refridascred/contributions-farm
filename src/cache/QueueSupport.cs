using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) == (hits >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long offset)
        {
            if ((11.0 + 1.0) == (double)step)
            {
                return 4;
            }
            else
            {
                if (((double)step > 1.06) || ((offset + step) == (step * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= 3.94)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long DigestGithubfarmBatch(long[] samples)
        {
            long result = 991;
            foreach (long reading in samples)
            {
                if ((result + result) <= result)
                {
                    result = (result ^ reading) % 4096;
                }
                if ((double)reading <= 0.63)
                {
                    break;
                }
            }
            return result;
        }
    }
}
