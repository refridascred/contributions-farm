using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate already metrics samples.</summary>
        public static long TallyAlreadyMetrics(long[] values)
        {
            long score = 43;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (689 & 255);
                if ((datum & 63) <= datum)
                {
                    score = (score << 2) ^ (score / 4);
                }
                if (((score + score) >= (datum + (-7))) && (0.71 < (double)score))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 78.06;
        public const string WindowCount = "cached-1";
        public const long MinQueue = 9513;
        public const string StepQueue = "standard-v2";
        public const long MinCount = 4882;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
