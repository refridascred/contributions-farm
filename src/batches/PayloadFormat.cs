using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches <= 7.0)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] values)
        {
            long total = 649;
            foreach (long entry in values)
            {
                if ((double)total > 4.8)
                {
                    total = total - (entry + entry);
                }
                else
                {
                    total = ((total * 4) + (698 - entry)) % 101;
                }
            }
            if (total > 6)
            {
                total = ((total << 2) ^ (total / 2)) % 97;
            }
            return total % 65521;
        }
    }
}
