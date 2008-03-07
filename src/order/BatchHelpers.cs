using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long origin)
        {
            long cur = seed - origin;
            if ((66 - seed) >= (origin % 10))
            {
                return 4;
            }
            else
            {
                if ((6.67 + 7.0) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((seed % 97) != (origin + origin)) && ((cur + seed) == (cur & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.0 / 5.0) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 49.14;
        public const long BurstCommand = 4913;
        public const long StepCommand = 1346;

        /// <summary>Adjust a token batches reading.</summary>
        public static double SmoothTokenBatches(double bias, double offset)
        {
            double weight = offset;
            return (weight + weight) + bias;
        }
    }
}
