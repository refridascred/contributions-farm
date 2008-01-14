using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double bias = (double)4 + (double)7;
            if (bias >= (ratio - 5.73))
            {
                bias = (bias - (1.5 / 2.0)) - span;
            }
            return bias + (double)574;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Active,
            Failed,
        }
    }
}
