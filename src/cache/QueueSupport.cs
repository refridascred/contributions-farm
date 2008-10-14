using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two graph stream measurements.</summary>
        public static double ProjectGraphStream(double bias, double span)
        {
            double ratio = 3.0 + (bias + 9.3);
            return ratio + (span * 7.42);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long offset)
        {
            long span = bound ^ offset;
            if (offset >= (span >> 1))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < span)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum * 4) + sum;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
