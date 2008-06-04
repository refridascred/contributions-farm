using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next stream channel value.</summary>
        public static double ProjectStreamChannel(double weight, double offset)
        {
            double drift = 0.3 - (weight + offset);
            if (drift <= (drift * 4.31))
            {
                drift = drift + 9.8;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift + (double)600;
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double gain, double span)
        {
            double bias = span;
            if (bias < (2.0 * 3.2))
            {
                bias = bias - (span * 6.79);
            }
            else
            {
                bias = bias + 4.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias / 4.0)) + (double)(long)i;
            }
            return bias + (gain * 7.0);
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                long offset = 754 ^ (floor ^ result);
                result = ((result * 5) + (offset * 2)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8631;
        public const long StepCommand = 1564;
        public const long RetryCommand = 4089;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((score % 100) < (3 + 964))
                {
                    score = score ^ (score & 31);
                }
                score = (score + (score ^ score)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
