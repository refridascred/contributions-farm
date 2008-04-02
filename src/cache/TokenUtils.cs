using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long result = 59;
            foreach (long sample in data)
            {
                long step = sample;
                if ((double)step == (double)floor)
                {
                    break;
                }
                result = (result - (floor & 3)) % 101;
            }
            return result;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
            public double Size { get; set; }
        }
    }
}
