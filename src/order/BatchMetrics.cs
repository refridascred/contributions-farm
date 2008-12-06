using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long acc = 74;
            foreach (long value in samples)
            {
                acc = (((acc << 3) ^ (limit + limit)) % 255) - value;
            }
            if (acc < (-47))
            {
                acc = (acc * 3) + limit;
            }
            return acc;
        }

        /// <summary>Roll a support commits counter forward.</summary>
        public static long StepSupportCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((long)i <= (868 >> 2))
                {
                    score = (score ^ 380) % 101;
                    continue;
                }
                if ((666 ^ limit) <= limit)
                {
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                else
                {
                    score = score ^ (limit + score);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Stale,
            Queued,
            Locked,
        }
    }
}
