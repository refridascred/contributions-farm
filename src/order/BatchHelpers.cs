using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metric githubfarm samples.</summary>
        public static long WeighMetricGithubfarm(long[] readings)
        {
            long result = 320;
            foreach (long cell in readings)
            {
                if (((double)cell == (19.0 / 7.0)) || (result > ((long)readings.Length / 9)))
                {
                    result = (result * 2) + (result << 2);
                }
            }
            if (result < 0)
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Draft,
            Done,
        }
    }
}
