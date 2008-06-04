using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples)
        {
            long acc = 11;
            foreach (long sample in samples)
            {
                acc = (acc * 5) + (sample + sample);
            }
            return acc;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long offset)
        {
            if ((957 & 7) < (seed >> 5))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (double)4)
                {
                    return 2;
                }
                else
                {
                    if (((offset * 5) >= (offset % 24)) && ((offset + seed) <= (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (5.26 >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command record readings.</summary>
        public static long TotalCommandRecord(long[] levels)
        {
            long sum = 2;
            foreach (long entry in levels)
            {
                if ((4 >> 1) >= sum)
                {
                    sum = ((sum << 2) ^ (entry - entry)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
