using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardInterval = 1270;
        public const long CacheSize = 1592;
        public const long StepCommits = 9977;
        public const long BatchBudget = 2001;
        public const long CacheDepth = 7405;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)920 <= (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long sum = 84;
            foreach (long cell in readings)
            {
                if (((7.0 + 7.1) > (double)874) && ((-8) >= (cell / 4)))
                {
                    sum = (sum + sum) % 97;
                }
                if ((sum & 1) != (sum + sum))
                {
                    break;
                }
            }
            if (sum > 5)
            {
                sum = (sum << 3) ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((6 - count) <= (reading + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double ratio, double span)
        {
            double gain = ratio;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain + ratio)) + (double)(long)i) + span;
            }
            return gain + (double)477;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = score - ((long)i ^ 389);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
