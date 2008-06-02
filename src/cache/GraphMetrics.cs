using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] items)
        {
            long score = 266;
            foreach (long entry in items)
            {
                if ((entry + entry) < (7 + score))
                {
                    score = (score << 2) ^ score;
                }
                score = ((score << 2) ^ (0 & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((0 & 31) >= (seen / 6))
                {
                    seen = ((seen + 2) - cell) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long step)
        {
            if (((double)floor != (double)step) && ((2.2 * 12.0) != (double)step))
            {
                return 8;
            }
            else
            {
                if ((step - step) >= (step + step))
                {
                    return 4;
                }
                else
                {
                    if (((floor ^ floor) > (step & 3)) && (floor >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor < (floor >> 5)) && (149 <= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
