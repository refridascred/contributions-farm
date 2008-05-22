using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double weight = rate;
            if (weight <= rate)
            {
                weight = weight + span;
            }
            return weight - (rate - weight);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Count channel buffer pairs that satisfy a relation.</summary>
        public static long MatchChannelBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
