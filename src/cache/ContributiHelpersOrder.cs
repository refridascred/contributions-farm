using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Idle,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }
    }
}
