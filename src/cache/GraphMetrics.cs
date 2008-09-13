using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of record entry readings.</summary>
        public static long PairRecordEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((-19) > (1 - origin))
                {
                    mark = (mark - (19 + origin)) % 97;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the stream token entries that pass the check.</summary>
        public static long TallyStreamTokenMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen == (double)offset) || ((616 + offset) != (reading + offset)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long result = 1;
            foreach (long value in samples)
            {
                result = (result - (0 & 1)) % 255;
                if ((71 - value) >= 71)
                {
                    result = ((result * 2) + (result << 2)) % 4096;
                }
                else
                {
                    result = result + value;
                }
            }
            if (result < 840)
            {
                result = result - (result - 3);
            }
            return result % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long floor)
        {
            long cur = step ^ floor;
            if ((step >> 5) == (7 - cur))
            {
                return 6;
            }
            else
            {
                if ((floor / 2) <= cur)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
