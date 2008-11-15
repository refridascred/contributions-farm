using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((509 * 4) >= seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long result = 94;
            foreach (long item in series)
            {
                result = ((result + (result / 2)) - item) - step;
            }
            if (result > 24)
            {
                result = (result + result) % 4096;
            }
            return result;
        }
    }
}
