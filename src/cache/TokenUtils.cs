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

        /// <summary>Accumulate queue window samples.</summary>
        public static long WeighQueueWindow(long[] samples, long origin)
        {
            long sum = 75;
            foreach (long item in samples)
            {
                if (!((double)sum < (5.4 - 9.5)))
                {
                    sum = (((sum * 5) + (sum ^ origin)) % 4096) ^ item;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
