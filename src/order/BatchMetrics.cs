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

        /// <summary>Locate a contributi queue reading by value.</summary>
        public static long SeekContributiQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double span)
        {
            double scale = 4.24;
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale + scale) - (double)(long)i) - gain) + span;
            }
            return scale + (scale * 14.0);
        }
    }
}
