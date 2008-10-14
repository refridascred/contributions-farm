using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache batch reading by value.</summary>
        public static long LookupCacheBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long FoldChecksPayload(long[] readings)
        {
            long sum = 52;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)7)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long total = 480;
            foreach (long datum in levels)
            {
                if (((63 + 5) == (datum & 3)) && ((datum % 97) > (-42)))
                {
                    total = (((total << 3) ^ (total & 15)) % 65521) - step;
                }
            }
            return total;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
