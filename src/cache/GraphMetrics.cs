using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double weight = (double)7 + ratio;
            if (weight <= ratio)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (weight / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (offset / 5.0)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Active,
            Done,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Queued,
            Ready,
        }
    }
}
