using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long MeasureMetricAlreadyMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((5.0 + 18.0) == (double)count)
                {
                    count = ((count + 2) - datum) + limit;
                }
            }
            return count;
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool VerifyCommandCounterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
