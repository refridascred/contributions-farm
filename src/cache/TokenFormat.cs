using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryScore = 75.91;
        public const double BurstTimeout = 16.85;
        public const long MinRatio = 9443;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step + step) <= 9)
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long target)
        {
            if ((double)step < (double)target)
            {
                return 6;
            }
            else
            {
                if (169 < step)
                {
                    return 4;
                }
                else
                {
                    if (6 < (step / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((11.0 - 7.88) != (double)target)
                        {
                            return 2;
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
}
