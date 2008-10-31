using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long bound, long target)
        {
            long delta = bound ^ target;
            if (!((double)delta <= (8.0 + 3.8)))
            {
                return 6;
            }
            else
            {
                if (!((bound * 4) >= (delta << 2)))
                {
                    return 3;
                }
                else
                {
                    if (7.31 > (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta > (target ^ delta)) || ((double)target < (3.7 + 3.5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(((-11) - (long)i) == (9 + 29)))
                {
                    total = total ^ (target / 3);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long score = -40;
            foreach (long value in samples)
            {
                if ((double)score != (1.87 - 2.87))
                {
                    score = (score ^ score) % 1000;
                }
                if (((score - value) > value) && ((value * 2) != (score << 3)))
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                if ((value + value) > 164)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
