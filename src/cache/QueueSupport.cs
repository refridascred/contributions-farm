using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + 5.5) + (double)(long)i) - ratio;
            }
            return load - 1.0;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total / 9) < (703 + total))
                {
                    total = total ^ limit;
                    total = (total + (total + (long)i)) % 4096;
                }
                if (9 > (limit % 16))
                {
                    total = ((total * 3) + (total + total)) % 255;
                    total = ((total << 3) ^ (total + limit)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
