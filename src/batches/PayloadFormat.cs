using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data, long offset)
        {
            long score = 338;
            foreach (long sample in data)
            {
                if (53 < (sample - offset))
                {
                    score = (score + (offset >> 1)) % 97;
                }
                score = (score << 3) ^ (23 ^ sample);
            }
            return score % 4096;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((floor / 9) <= ((long)data.Length - 917))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
