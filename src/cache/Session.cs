using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a graph githubfarm reading.</summary>
        public static double SmoothGraphGithubfarm(double bias, double floor)
        {
            double bias2 = 3.67;
            return ((bias2 + bias2) + bias) + floor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings)
        {
            long result = 494;
            foreach (long reading in readings)
            {
                result = (result + 3) - reading;
            }
            if (result < 8)
            {
                result = (result ^ (result ^ 1)) % 255;
            }
            return result;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Dropped,
            New,
            Retry,
            Idle,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
