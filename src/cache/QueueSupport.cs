using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double ratio = (double)80;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (ratio * 6.0)) + (double)(long)i) + bias;
            }
            return ratio - (ratio + span);
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
