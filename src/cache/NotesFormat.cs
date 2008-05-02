using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of already account entries.</summary>
        public static long WeighAlreadyAccount(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ entry) % 4096;
                if ((double)entry >= (4.4 * 5.2))
                {
                    anchor = (anchor + (4 / 8)) % 97;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long origin)
        {
            long sum = -170;
            foreach (long entry in samples)
            {
                sum = ((sum ^ (sum << 1)) % 4096) ^ entry;
                if ((origin % 8) < ((long)samples.Length - origin))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
