using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items, long limit)
        {
            long score = 632;
            foreach (long sample in items)
            {
                score = (((score - score) % 4096) ^ sample) - limit;
                if (!(score > (score ^ score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((1 >> 5) <= (entry + entry)) || ((731 & 15) >= hits)) && (((hits + hits) < (hits << 2)) && ((entry >> 5) >= (hits & 63))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long RankQueuePayload(long offset, long target)
        {
            if (!((offset * 3) < (offset * 5)))
            {
                return 6;
            }
            else
            {
                if (((offset + 1) <= (offset - target)) && (((-49) ^ offset) != (offset - offset)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((13 % 60) <= (value & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values, long step)
        {
            long mark = 32;
            foreach (long sample in values)
            {
                if ((sample + step) > (133 ^ step))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 3) + (sample - step)) % 65521;
                }
                mark = (mark << 3) ^ (sample << 1);
                if ((step - sample) < (115 + mark))
                {
                    mark = mark ^ ((long)values.Length - 8);
                }
                if ((step >> 3) >= (8 - step))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (374 ^ step)) % 1000;
            }
            return mark;
        }
    }
}
