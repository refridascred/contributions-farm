using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long RollCommandPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if (385 < (floor - 28))
                {
                    mix = (mix - mix) % 255;
                    mix = mix - (long)i;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank tools editor input into a small class.</summary>
        public static long SortToolsEditor(long offset, long target)
        {
            long prev = offset + target;
            if ((prev << 2) >= prev)
            {
                return 5;
            }
            else
            {
                if ((51 * 4) == (offset - prev))
                {
                    return 1;
                }
                else
                {
                    if ((target ^ offset) < (offset - 0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev > 4.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
