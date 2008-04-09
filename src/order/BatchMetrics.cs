using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long step2)
        {
            if ((step % 3) < step2)
            {
                return 5;
            }
            else
            {
                if (0.75 > (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (10.0 * 4.3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double drift = bias - (bias + floor);
            if (drift <= floor)
            {
                drift = drift - (floor / 9.0);
            }
            return drift + (bias - bias);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((0.9 + 5.03) > (double)bound)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series)
        {
            long carry = -2;
            foreach (long reading in series)
            {
                carry = (carry ^ (81 - 57)) + reading;
            }
            return carry % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchBudget = 8834;
        public const long MaxInterval = 1210;
        public const double BatchDepth = 19.48;
        public const long BaseLevel = 5073;
        public const double MinBudget = 65.35;
    }
}
