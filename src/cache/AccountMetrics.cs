using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of account queue readings.</summary>
        public static long PairAccountQueueCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer layout pair into a bucket.</summary>
        public static long RankBufferLayout(long seed, long floor)
        {
            if (((-482) + 22) > (floor << 2))
            {
                return 3;
            }
            else
            {
                if ((seed << 2) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats counter samples.</summary>
        public static long ScoreStatsCounter(long[] readings, long step)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = (anchor + step) % 1000;
                if (1.13 >= (double)sample)
                {
                    anchor = (anchor ^ (long)readings.Length) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (6 + step)) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 2) + (step + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Dropped,
            Failed,
        }
    }
}
