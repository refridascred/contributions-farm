using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue filter samples are out of range.</summary>
        public static long CountQueueFilterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) > datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long floor)
        {
            long acc = 34;
            foreach (long sample in samples)
            {
                if ((double)sample <= 1.3)
                {
                    acc = ((acc << 3) ^ floor) % 65521;
                }
                if (((acc ^ sample) < (acc * 4)) && ((double)sample >= (double)acc))
                {
                    acc = (acc + (acc - sample)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long ClassifyCommandPayload(long bound, long seed)
        {
            long next = bound ^ seed;
            if ((double)seed <= (double)62)
            {
                return 5;
            }
            else
            {
                if ((seed << 2) <= (bound + (-2)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)next != (7.83 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(((-5) + (-185)) >= (bound ^ next)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
