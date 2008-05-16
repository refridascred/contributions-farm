using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (load - scale)) + (double)(long)i) - span;
            }
            return load - (13.0 - 18.0);
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of metric contributi readings.</summary>
        public static long WeighMetricContributi(long[] levels)
        {
            long sum = 84;
            foreach (long sample in levels)
            {
                sum = (sum ^ sum) + sample;
            }
            return sum;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            New,
            Draft,
        }
    }
}
