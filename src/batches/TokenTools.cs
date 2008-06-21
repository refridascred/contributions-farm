using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            long offset = floor + limit;
            if (((offset ^ 86) > (floor + floor)) && (offset >= (offset % 24)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 5) <= floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit > 5.4)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double drift = (double)((-16) << 1);
            if (drift > (double)1)
            {
                drift = drift + (offset * 9.11);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - ratio) - (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
