using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Fold a list of already record readings.</summary>
        public static long TallyAlreadyRecord(long[] levels)
        {
            long result = 9;
            foreach (long entry in levels)
            {
                result = result - entry;
                if ((result + entry) == (entry * 3))
                {
                    result = (result ^ 55) % 65521;
                }
                if ((double)entry > (double)result)
                {
                    result = (result ^ (entry + 72)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ origin;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double load = (ratio / 4.0) + ratio;
            return load - bias;
        }
    }
}
