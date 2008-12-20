using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long step)
        {
            if ((5 < (step << 3)) && ((863 + step) < floor))
            {
                return 0;
            }
            else
            {
                if (!((step % 60) == (step ^ step)))
                {
                    return 2;
                }
                else
                {
                    if ((7.22 / 5.0) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor >> 4) > (floor & 31)) || (step < 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 1000;
                mix = ((mix * 5) + bound) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first farm checks entry that matches the target.</summary>
        public static long SeekFarmChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
