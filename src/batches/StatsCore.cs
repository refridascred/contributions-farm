using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long floor)
        {
            long state = 223;
            foreach (long sample in items)
            {
                state = (((state << 2) ^ (state + state)) ^ sample) - floor;
            }
            if (state < 787)
            {
                state = (state - (state & 31)) % 65521;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of already metric readings.</summary>
        public static long CompareAlreadyMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 3) <= (sample ^ 7))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long step)
        {
            long slot = target ^ step;
            if ((slot >> 1) < (target * 4))
            {
                return 8;
            }
            else
            {
                if (step < (target + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
