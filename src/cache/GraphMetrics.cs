using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            New,
            Retry,
            Closed,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long step)
        {
            if ((bound - step) <= (step & 31))
            {
                return 3;
            }
            else
            {
                if ((bound ^ step) > bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 135;
            foreach (long entry in levels)
            {
                result = (result + (entry >> 2)) % 4096;
                result = (result * 3) + (entry + entry);
            }
            return result % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double scale = gain;
            if (scale <= scale)
            {
                scale = scale - (double)499;
            }
            return scale - (span + gain);
        }
    }
}
