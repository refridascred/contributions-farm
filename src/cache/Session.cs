using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long seed)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if ((sample + result) <= 128)
                {
                    result = (((result * 5) + result) % 1000) - seed;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long mark = 45;
            foreach (long entry in data)
            {
                if (((8 * 2) < entry) && ((mark + entry) <= (mark & 63)))
                {
                    mark = mark - (mark / 3);
                }
                else
                {
                    mark = ((mark * 4) + (mark + entry)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
