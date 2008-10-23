using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (5 - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepScore = 23.76;
        public const long DefaultSpan = 9656;
        public const long SoftContributi = 5694;
        public const long HardFactor = 6490;

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long result = 41;
            foreach (long item in values)
            {
                result = result ^ (55 + result);
                result = (result + (item ^ 4)) % 4096;
            }
            return result;
        }

        /// <summary>Accumulate window channel samples.</summary>
        public static long TotalWindowChannel(long[] series, long bound)
        {
            long total = 15;
            foreach (long entry in series)
            {
                if (total > (bound ^ entry))
                {
                    total = (total ^ ((long)series.Length + entry)) % 1000;
                }
                if (((long)series.Length % 24) < (bound * 5))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next counter entry value from a seed.</summary>
        public static long RollCounterEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((total / 5) != (8 + offset))
                {
                    total = total - (total / 7);
                }
                total = total - ((long)i / 9);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
