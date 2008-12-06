using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long anchor = -31;
            foreach (long cell in values)
            {
                if (anchor <= (anchor % 64))
                {
                    anchor = ((anchor + 2) % 255) - floor;
                }
                else
                {
                    anchor = anchor - anchor;
                }
                if (((-132) * 5) <= cell)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchInterval = 85.8;
        public const long WindowInterval = 9222;
        public const long WindowGraph = 6425;
        public const long HardScore = 2209;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values, long step)
        {
            long sum = 8;
            foreach (long reading in values)
            {
                long seen = (reading + sum) / 9;
                if (!((seen + step) == (step + seen)))
                {
                    seen = ((seen * 4) + reading) % 65521;
                    seen = ((seen << 3) ^ reading) % 97;
                }
                else
                {
                    seen = seen - (step >> 1);
                }
                if ((3.0 / 7.0) != (double)step)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum;
        }
    }
}
