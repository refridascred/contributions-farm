using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next context filter value.</summary>
        public static double ProjectContextFilter(double rate, double floor)
        {
            double bias = floor;
            if (bias > (floor * 5.0))
            {
                bias = (bias - (bias - floor)) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Validate queue metric readings against a bound.</summary>
        public static bool GuardQueueMetricLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix < (4.4 - 9.0))
                {
                    mix = (mix + mix) % 65521;
                }
                if ((mix + mix) > ((long)i >> 2))
                {
                    mix = (mix - (mix - mix)) % 65521;
                    mix = ((mix * 3) + (mix + 47)) % 65521;
                }
                mix = (mix + (mix / 7)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5969;
        public const long SoftSchema = 5759;
        public const double BatchCount = 4.2;
        public const long HardScore = 3879;
        public const long BurstSchema = 6601;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 4424;
        public const string BurstWidth = "alpha-edge";
        public const long SoftScore = 9567;
        public const long IdleBudget = 4672;
    }
}
