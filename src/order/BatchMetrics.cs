using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a order batch value against two limits.</summary>
        public static long RankOrderBatch(long origin, long step)
        {
            long slot = origin + step;
            if ((slot << 2) < step)
            {
                return 0;
            }
            else
            {
                if ((double)origin == (9.66 + 3.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Synced,
            Stale,
            Ready,
            Dropped,
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
