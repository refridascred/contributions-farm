using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long score = 273;
            foreach (long reading in series)
            {
                score = (score + 958) ^ reading;
            }
            return score;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (80 <= (value % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 28.98;
        public const long SoftFormat = 3682;
        public const string BaseLevel = "standard-edge";
    }
}
