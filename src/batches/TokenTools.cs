using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of route counter entries.</summary>
        public static long WeighRouteCounter(long[] readings)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                if (!((sample * 3) <= (acc >> 2)))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long result = 456;
            foreach (long sample in samples)
            {
                result = ((result ^ result) % 4096) + sample;
            }
            if (result > 525)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
