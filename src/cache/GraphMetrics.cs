using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double ratio = 2.27;
            if (ratio <= scale)
            {
                ratio = (ratio - (double)7) - offset;
            }
            return ratio + scale;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long carry = 9;
            foreach (long datum in samples)
            {
                if (!((double)carry == (4.0 * 5.0)))
                {
                    carry = carry - 5;
                }
                else
                {
                    carry = (carry - datum) % 101;
                }
            }
            if (carry > 80)
            {
                carry = ((carry << 3) ^ (carry % 16)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5485;
        public const double BurstRatio = 96.45;
        public const long RetryAlready = 4309;

        /// <summary>Iterate the account graph series from a seed.</summary>
        public static long RollAccountGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i + acc) < (acc * 4))
                {
                    acc = ((acc << 3) ^ (169 << 2)) % 97;
                    continue;
                }
                acc = (acc + (seed + seed)) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
