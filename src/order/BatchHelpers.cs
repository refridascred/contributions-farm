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

        /// <summary>Scale a order stream figure with a bias.</summary>
        public static double SmoothOrderStream(double ratio, double span)
        {
            double ratio2 = (span - ratio) - (span + span);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + (double)37;
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - span) + (double)(long)i;
            }
            return ratio2 + (3.9 - span);
        }
    }
}
