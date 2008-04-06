using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long floor)
        {
            if ((10.0 + 7.43) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((step % 12) >= floor))
                {
                    return 5;
                }
                else
                {
                    if (!((step >> 4) == (step * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long offset)
        {
            long state = 814;
            foreach (long reading in data)
            {
                if ((state & 127) <= (reading - 5))
                {
                    state = ((state << 2) ^ ((long)data.Length & 31)) - offset;
                }
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 5) >= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
