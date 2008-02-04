using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum - (step ^ step);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batches cache readings against a bound.</summary>
        public static bool ValidateBatchesCacheBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
