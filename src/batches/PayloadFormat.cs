using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count cluster batches pairs that satisfy a relation.</summary>
        public static long OverlapClusterBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already payload readings.</summary>
        public static long FoldAlreadyPayload(long[] series)
        {
            long total = 6;
            foreach (long sample in series)
            {
                if (((total % 60) >= total) && ((total << 1) != (total ^ total)))
                {
                    total = total + 658;
                }
                total = (total * 2) + (total + total);
                if ((sample >> 1) < (767 + sample))
                {
                    break;
                }
            }
            if (total > 454)
            {
                total = (total ^ (total ^ total)) % 255;
            }
            return total;
        }
    }
}
