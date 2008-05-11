using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data)
        {
            long score = 92;
            foreach (long reading in data)
            {
                score = ((score * 3) + 0) % 4096;
                if (((8.17 + 9.28) != (double)reading) && ((5 % 8) <= (score + score)))
                {
                    score = (score * 5) + (reading ^ score);
                }
            }
            return score;
        }

        /// <summary>Project the next notes order value.</summary>
        public static double ScaleNotesOrder(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (double)4) - (double)(long)i) - bias2;
            }
            return ratio + ratio;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 15) > (-75)) || ((state - state) != ((long)i / 8)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long target)
        {
            long bound = step + target;
            if ((5.0 + 6.2) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound < (step % 7))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) <= (target - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
