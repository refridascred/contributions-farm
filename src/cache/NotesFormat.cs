using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long bound)
        {
            long slot = step ^ bound;
            if (((7.1 - 6.49) <= (double)slot) && ((87 - bound) != (slot + step)))
            {
                return 4;
            }
            else
            {
                if ((bound < (818 + bound)) && (94 > (step + slot)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot >= (1.87 + 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound != (double)1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double drift = 10.0;
            if (drift <= (8.9 - bias))
            {
                drift = (drift + drift) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
