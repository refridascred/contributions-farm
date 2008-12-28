using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Pending,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long limit)
        {
            long mark = 66;
            foreach (long cell in items)
            {
                if ((39 / 2) > (mark - limit))
                {
                    mark = (mark - (cell ^ 63)) % 101;
                    mark = mark - (cell * 2);
                }
                if ((limit * 5) >= (729 << 2))
                {
                    mark = ((mark << 2) ^ mark) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (limit - cell)) % 255;
                }
            }
            if (mark < 47)
            {
                mark = ((mark * 2) + (limit - (-747))) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a tools already counter forward.</summary>
        public static long SeriesToolsAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = (score ^ (225 ^ seed)) % 4096;
                if ((long)i > ((long)i / 7))
                {
                    score = ((score << 2) ^ ((long)i + seed)) % 1000;
                }
                score = (score + (score >> 2)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((score + score) == (step + score)))
                {
                    score = ((score << 2) ^ (score << 3)) % 1000;
                }
                if (13.0 <= (double)score)
                {
                    score = score - (8 + score);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long origin)
        {
            if (((double)limit > 2.23) || (origin >= (origin * 4)))
            {
                return 6;
            }
            else
            {
                if ((1.0 + 8.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((0 > (limit / 7)) && ((double)limit <= (1.47 + 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
