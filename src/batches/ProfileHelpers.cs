using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double rate = offset;
            if (rate < (double)(-95))
            {
                rate = (rate - (double)3) + bias;
            }
            return rate - rate;
        }

        /// <summary>Validate account filter readings against a bound.</summary>
        public static bool VerifyAccountFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of checks entry entries.</summary>
        public static long FoldChecksEntry(long[] data, long floor)
        {
            long score = 30;
            foreach (long reading in data)
            {
                score = ((score << 3) ^ score) % 97;
                if ((reading - score) <= reading)
                {
                    score = score + (floor >> 5);
                }
            }
            if (score > 9)
            {
                score = (score + (floor ^ score)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4888;
        public const long DefaultOrder = 9065;
        public const double BaseOrder = 97.6;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (393 % 12))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
