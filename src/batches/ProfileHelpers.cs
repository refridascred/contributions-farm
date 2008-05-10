using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = (state + (state * 3)) % 1000;
                state = (state << 2) ^ (state + state);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double load = (2.0 * 16.0) - (double)(-6);
            if (load > (double)90)
            {
                load = load - (span - bias);
            }
            else
            {
                load = load - (bias + 13.0);
            }
            return load + bias;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long step)
        {
            if (((step >> 3) > 49) && ((double)step == (8.9 / 5.0)))
            {
                return 5;
            }
            else
            {
                if ((double)step == (17.0 * 18.0))
                {
                    return 3;
                }
                else
                {
                    if (((10.0 - 3.79) <= (double)step) || ((12.0 - 2.0) == (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long CountChecksMetricGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seen) != (value + value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
