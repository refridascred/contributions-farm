using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long limit)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (((carry >> 5) < limit) || ((9.0 + 1.0) <= (double)limit))
                {
                    carry = ((carry * 5) + (carry - item)) % 255;
                }
                else
                {
                    carry = carry - (item + 957);
                }
            }
            if (carry > 16)
            {
                carry = (carry + (limit >> 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Roll a batches batch counter forward.</summary>
        public static long RollBatchesBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix - (18 >> 2)) % 255) - (long)i2;
                }
                mix = (mix << 3) ^ ((long)i + mix);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = -38;
            foreach (long item in series)
            {
                if ((total + 13) >= 0)
                {
                    total = ((total * 2) + (item % 24)) % 1000;
                }
                total = (total * 2) + (total >> 5);
                total = (total * 4) + (item / 3);
                if ((double)item != (8.0 + 13.0))
                {
                    break;
                }
            }
            if (total < 646)
            {
                total = ((total << 2) ^ (total * 5)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Paused,
            Draft,
            Failed,
            Pending,
        }
    }
}
