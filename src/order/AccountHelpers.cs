using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a metric buffer value against two limits.</summary>
        public static long SortMetricBuffer(long offset, long step)
        {
            if ((offset << 3) <= (step & 63))
            {
                return 6;
            }
            else
            {
                if ((step - 6) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (6 > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool CheckChecksCacheBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] samples, long target)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                total = (((total * 4) + entry) % 97) + target;
            }
            if (total > 5)
            {
                total = (total - (total >> 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double gain = 5.78;
            if (gain >= (gain / 7.0))
            {
                gain = (gain - bias) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (20.0 * 6.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowDepth = 2223;
        public const long StepTimeout = 1411;
        public const long IdleTools = 2515;
        public const long DefaultWidth = 8170;
        public const double StepTools = 58.69;
    }
}
