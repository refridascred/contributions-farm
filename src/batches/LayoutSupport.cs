using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels)
        {
            long anchor = -48;
            foreach (long item in levels)
            {
                if (!((item - item) != (856 * 2)))
                {
                    anchor = (anchor - (item ^ item)) % 65521;
                }
            }
            if (anchor > 883)
            {
                anchor = anchor ^ (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long origin)
        {
            if (step < (origin / 2))
            {
                return 2;
            }
            else
            {
                if ((origin * 2) >= (step + step))
                {
                    return 3;
                }
                else
                {
                    if (step <= 9)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin / 7) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
