using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((limit << 1) >= (limit & 3)))
                {
                    continue;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    mix = ((mix << 2) ^ limit) ^ (long)i3;
                    mix = mix - (mix ^ limit);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Closed,
            Dropped,
            Synced,
            Active,
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

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > 9.1)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)5;
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
