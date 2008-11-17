using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Stale,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if (!((107 - bound) >= (datum + datum)))
                {
                    carry = carry - (bound - carry);
                }
                else
                {
                    carry = ((carry << 3) ^ 95) % 97;
                }
                if (6 < (datum + datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((7 << 1) > limit))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double ProjectTokenLayout(double scale, double offset)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = (drift + (double)651) + offset;
            }
            else
            {
                drift = drift - (scale / 4.0);
            }
            return drift + (2.3 / 8.0);
        }
    }
}
