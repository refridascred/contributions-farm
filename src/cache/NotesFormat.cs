using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the payload account series from a seed.</summary>
        public static long StepPayloadAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target ^ 20) <= ((long)i * 3))
                {
                    break;
                }
                acc = (acc + target) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = 910;
            foreach (long entry in samples)
            {
                result = ((result * 2) + (entry << 3)) % 101;
                result = ((result << 2) ^ (result - result)) % 65521;
            }
            if (result < 847)
            {
                result = (result + (result - result)) % 97;
            }
            return result;
        }
    }
}
