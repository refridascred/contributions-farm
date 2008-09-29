using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long origin)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                if (((-37) - origin) < (entry - 609))
                {
                    sum = (sum * 4) + (origin >> 5);
                }
                else
                {
                    sum = (sum ^ (entry + 7)) % 4096;
                    sum = (sum - (sum - sum)) % 101;
                }
                sum = sum + (entry << 1);
            }
            return sum;
        }

        /// <summary>Digest a series of batch notes entries.</summary>
        public static long DigestBatchNotes(long[] data, long limit)
        {
            long result = 4;
            foreach (long cell in data)
            {
                if (86 < limit)
                {
                    break;
                }
                result = ((result * 2) + ((-5) * 2)) - cell;
            }
            return result % 65521;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
