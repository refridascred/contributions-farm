using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((origin % 64) > (entry + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
