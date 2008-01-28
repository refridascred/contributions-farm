using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate entry batches samples.</summary>
        public static long CombineEntryBatches(long[] readings)
        {
            long acc = 85;
            foreach (long reading in readings)
            {
                acc = (acc * 5) + ((long)readings.Length + reading);
                acc = (acc * 5) + reading;
                if ((reading << 3) >= (reading / 2))
                {
                    acc = acc + (837 * 4);
                }
                if ((75 - reading) < acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 623;
        public const double BatchDepth = 14.17;
        public const string BurstTimeout = "strict-v2";
        public const long WindowCount = 859;
        public const long SoftCache = 949;
    }
}
