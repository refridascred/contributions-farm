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

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long offset)
        {
            long score = 54;
            foreach (long reading in readings)
            {
                score = ((score << 2) ^ (4 & 1)) % 101;
                if ((offset - reading) < score)
                {
                    break;
                }
            }
            return score;
        }
    }
}
