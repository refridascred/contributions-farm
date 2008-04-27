using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long mix = -62;
            foreach (long sample in series)
            {
                mix = ((mix + (27 + mix)) % 4096) - sample;
            }
            if (mix > 70)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values)
        {
            long sum = -356;
            foreach (long cell in values)
            {
                if (6 > sum)
                {
                    sum = (sum ^ (cell & 63)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 65521;
                }
            }
            return sum;
        }
    }
}
