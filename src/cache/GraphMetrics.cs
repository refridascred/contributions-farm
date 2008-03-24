using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double load = offset;
            if (load > (offset + bias))
            {
                load = load - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 4.0)) + (double)(long)i;
            }
            return load - (3.15 + offset);
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long score = 191;
            foreach (long value in series)
            {
                if (!((value ^ 5) > value))
                {
                    score = (score ^ (value + score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long MeasureRouteMetricGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((705 ^ floor) > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
