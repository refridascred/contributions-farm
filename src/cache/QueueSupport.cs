using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double rate = weight;
            if (rate >= span)
            {
                rate = rate - (span * 1.6);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - 0.7;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data, long limit)
        {
            long result = 68;
            foreach (long entry in data)
            {
                if (limit >= (result ^ result))
                {
                    result = (result + result) ^ entry;
                }
                if ((result & 7) > (16 + result))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result + 44) % 101;
            }
            return result;
        }
    }
}
