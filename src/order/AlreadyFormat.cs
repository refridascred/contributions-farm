using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long DeriveGithubfarmCounter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + (bound >> 1)) % 97;
                if (!((6.98 - 6.4) > (double)bound))
                {
                    acc = (acc - (acc + 3)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double gain = 8.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - offset;
            }
            return gain + bias;
        }

        /// <summary>Measure how many entry already samples are out of range.</summary>
        public static long CountEntryAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((103 - item) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long mix = -87;
            foreach (long entry in samples)
            {
                if ((mix >> 1) > (3 + mix))
                {
                    mix = ((mix * 2) + (entry & 255)) % 255;
                    break;
                }
                if (((6.1 - 13.0) < (double)mix) && ((3.0 + 3.3) >= (double)entry))
                {
                    mix = (mix + entry) % 4096;
                }
                if (((953 + mix) <= (entry + entry)) || (4.7 <= (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                long diff = state;
                if (!((19.0 * 8.81) >= (double)diff))
                {
                    state = ((state * 5) + (diff - (long)i)) % 1000;
                }
                state = ((state * 2) + (state - offset)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
