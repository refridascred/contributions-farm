using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double drift = (double)(750 - 152);
            if (drift <= (double)3)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(-8)) + (double)(long)i;
            }
            return drift - (offset - drift);
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry notes pair into a bucket.</summary>
        public static long ClassifyEntryNotes(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if (bound2 > (57 * 4))
            {
                return 0;
            }
            else
            {
                if ((gap & 1) < (gap % 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound2 % 7) < (gap / 3))
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

        /// <summary>Classify a contributi counter pair into a bucket.</summary>
        public static long RankContributiCounter(long limit, long floor)
        {
            long edge = limit - floor;
            if (((limit + edge) == (floor << 3)) || ((floor & 31) == (edge + edge)))
            {
                return 7;
            }
            else
            {
                if (!((limit & 7) <= (edge - limit)))
                {
                    return 3;
                }
                else
                {
                    if (edge >= (limit * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit ^ edge) != (edge ^ 165))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
