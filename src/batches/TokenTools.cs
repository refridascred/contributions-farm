using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long limit)
        {
            if (limit >= (step - limit))
            {
                return 8;
            }
            else
            {
                if (9.36 <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + step) == (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 ^ limit) != (step + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6463;
        public const long HardCache = 8059;
        public const long BurstSize = 3039;
        public const double BurstBudget = 64.6;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)limit >= (1.0 - 8.0))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
