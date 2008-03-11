using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long floor)
        {
            long total = 459;
            foreach (long value in samples)
            {
                if ((total * 3) <= (floor ^ total))
                {
                    total = ((total + (90 << 3)) % 1000) ^ value;
                }
                else
                {
                    total = ((total * 2) + (total / 6)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long seed, long limit)
        {
            if ((double)limit > (1.0 * 5.0))
            {
                return 0;
            }
            else
            {
                if ((742 * 5) >= seed)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
