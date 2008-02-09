using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (171 <= (count - count))
                {
                    count = ((count + 1) - sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                sum = (((sum << 3) ^ 95) % 4096) + value;
            }
            return sum % 97;
        }
    }
}
