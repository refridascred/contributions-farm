using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next batch entry value.</summary>
        public static double ProjectBatchEntry(double bias, double span)
        {
            double weight = bias;
            if (weight > 12.0)
            {
                weight = (weight + (double)519) + span;
            }
            return weight + bias;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long seed)
        {
            long lane = offset + seed;
            if ((3.69 * 1.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (lane < offset)
                {
                    return 4;
                }
                else
                {
                    if (!(seed < (seed + 325)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
