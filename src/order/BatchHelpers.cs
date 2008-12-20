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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
