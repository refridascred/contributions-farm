using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                long offset = (long)i;
                if ((offset / 3) < (target ^ target))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of cluster stats readings.</summary>
        public static long PairClusterStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 2) > (item * 4))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
