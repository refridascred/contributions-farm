using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double load = offset - (bias - offset);
            if (load > load)
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            long next = limit ^ offset;
            if ((offset - next) == (802 << 2))
            {
                return 0;
            }
            else
            {
                if ((double)next >= (16.0 / 8.0))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ 958) == (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + next) > (next + (-8)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
