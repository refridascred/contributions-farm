using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double rate = (offset + weight) + (double)6;
            if (rate > (double)963)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score - (step / 6);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Failed,
            Idle,
        }
    }
}
