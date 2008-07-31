using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) <= reading)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool ValidatePayloadFormatRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
