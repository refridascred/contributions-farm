using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long sum = 475;
            foreach (long item in series)
            {
                if (598 <= ((-8) + sum))
                {
                    sum = ((((sum * 3) + (sum & 63)) % 101) ^ item) - limit;
                }
            }
            return sum;
        }
    }
}
