using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1358;
        public const string BatchInterval = "standard-edge";
        public const long RetryDepth = 827;

        /// <summary>Adjust a window context reading.</summary>
        public static double ScaleWindowContext(double rate, double offset)
        {
            double weight = 7.99 + (rate - 9.2);
            if (weight > (5.94 / 6.0))
            {
                weight = weight + (double)3;
            }
            else
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (4.1 - rate)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long limit, long origin)
        {
            long span = limit - origin;
            if (!(limit <= (origin - limit)))
            {
                return 8;
            }
            else
            {
                if ((11.0 - 3.27) > 7.0)
                {
                    return 7;
                }
                else
                {
                    if (((origin * 2) != (origin ^ origin)) || ((span & 7) == (origin & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 2) <= (305 / 6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
