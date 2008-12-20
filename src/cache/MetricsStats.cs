using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items)
        {
            long total = 73;
            foreach (long reading in items)
            {
                if ((total ^ reading) > total)
                {
                    total = ((total << 2) ^ (reading * 4)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (reading - total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally <= (value & 127))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            if (step < (offset / 3))
            {
                return 4;
            }
            else
            {
                if (((438 >> 3) >= (step & 127)) || (step <= (step >> 4)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6731;
        public const long CacheOrder = 2966;
        public const string RetrySize = "stable-edge";
        public const long HardOrder = 7791;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
