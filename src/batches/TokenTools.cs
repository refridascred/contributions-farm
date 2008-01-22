using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window payload value.</summary>
        public static double BlendWindowPayload(double weight, double span)
        {
            double rate = (double)783 + span;
            if (rate < (rate + weight))
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long floor, long limit)
        {
            if (!(floor > (limit ^ floor)))
            {
                return 7;
            }
            else
            {
                if (9.04 >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (((double)limit <= (1.81 / 4.0)) || ((limit / 3) <= 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit / 8) >= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - cell) == (matches & 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
