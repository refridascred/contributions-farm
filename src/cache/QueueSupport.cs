using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((0.46 + 7.7) > (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
