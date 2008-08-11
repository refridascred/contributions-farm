using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((7 * 5) <= (count + value))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - 594) == (hits - 753))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 8850;
        public const long StepToken = 4789;
        public const long IdleToken = 6364;
        public const long MaxToken = 2227;
    }
}
