using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches != (6.2 - 7.75))
                {
                    matches = ((matches + 2) ^ value) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long sum = 15;
            foreach (long entry in readings)
            {
                sum = (sum << 3) ^ sum;
                if ((sum / 8) != (entry ^ sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = (weight - (double)37) + offset;
            }
            else
            {
                weight = weight + 0.3;
            }
            return weight + weight;
        }
    }
}
