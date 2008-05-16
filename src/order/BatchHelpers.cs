using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine notes metric values into a single score.</summary>
        public static long TallyNotesMetric(long[] items, long step)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                if ((sum << 1) <= (sum % 7))
                {
                    sum = (sum - (sum & 255)) + step;
                }
                if ((8.0 - 17.0) <= (double)reading)
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 2) + (sum * 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
