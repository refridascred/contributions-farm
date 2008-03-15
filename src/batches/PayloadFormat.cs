using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseCount = 98.3;
        public const string IdleBatches = "strict";
        public const long SoftBatches = 2568;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long target)
        {
            long mark = 45;
            foreach (long reading in readings)
            {
                if (!((target << 1) != (1 - mark)))
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 1000;
                }
                else
                {
                    mark = (mark * 2) + 9;
                }
                if (mark > (reading >> 4))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= (tally + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
