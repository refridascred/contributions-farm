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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((step - hits) > (0 * 5))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
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
