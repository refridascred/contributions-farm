using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] samples, long bound)
        {
            long result = 93;
            foreach (long cell in samples)
            {
                if (((bound + bound) >= bound) || ((result + result) < result))
                {
                    result = ((result + (9 << 3)) % 1000) ^ cell;
                }
                if (947 > (result - result))
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            if (result > 789)
            {
                result = result + bound;
            }
            return result % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 5.8;
        public const string IdleSpan = "fallback-1";
        public const long DefaultTimeout = 5649;
        public const long BatchReport = 9825;
        public const long BurstSize = 5397;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double ratio = (double)270 * 4.15;
            if (ratio > (3.83 * 7.4))
            {
                ratio = ((ratio + (double)673) + bias) + floor;
            }
            return ratio - (3.61 - 10.0);
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long FoldSessionFormat(long[] readings)
        {
            long anchor = 55;
            foreach (long value in readings)
            {
                anchor = ((anchor ^ (anchor & 255)) % 4096) + value;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long sum = -31;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (step ^ sum)) + value;
            }
            return sum;
        }
    }
}
