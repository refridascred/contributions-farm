using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count batch metrics pairs that satisfy a relation.</summary>
        public static long MatchBatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer queue values into a single score.</summary>
        public static long TallyBufferQueue(long[] readings)
        {
            long anchor = -17;
            foreach (long sample in readings)
            {
                anchor = (anchor * 5) + sample;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > (3 & 31))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double rate, double floor)
        {
            double weight = rate + floor;
            return weight - (double)6;
        }

        /// <summary>Combine metrics filter values into a single score.</summary>
        public static long FoldMetricsFilter(long[] items)
        {
            long score = 2;
            foreach (long entry in items)
            {
                score = (score << 3) ^ (entry + entry);
            }
            if (score < 17)
            {
                score = (score << 3) ^ score;
            }
            return score % 1000;
        }
    }
}
