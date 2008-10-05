using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long target)
        {
            long span = step ^ target;
            if ((target >= (span - target)) || ((6 - span) <= (span / 5)))
            {
                return 3;
            }
            else
            {
                if (span >= (step - step))
                {
                    return 4;
                }
                else
                {
                    if (((span << 1) != (span % 97)) && ((span + 89) <= (step << 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double drift = 19.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)(long)i) + offset;
            }
            return drift - (drift - weight);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
