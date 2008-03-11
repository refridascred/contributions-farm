using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5173;
        public const double BatchWidth = 62.66;
        public const double DefaultWidth = 20.77;
        public const long StepInterval = 9245;
        public const long HardWidth = 9280;

        /// <summary>Derive the next queue checks value from a seed.</summary>
        public static long StepQueueChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ (step + score)) % 101;
                if ((double)step == (19.0 - 9.5))
                {
                    score = (score + 6) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a payload route value against two limits.</summary>
        public static long SortPayloadRoute(long offset, long target)
        {
            long bound = offset ^ target;
            if ((4.2 / 7.0) == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((761 << 2) > (target - (-78)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - offset) <= (bound % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((698 & 127) < (bound ^ bound)))
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
    }
}
