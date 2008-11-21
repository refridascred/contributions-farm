using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 1739;
        public const long WindowCluster = 3825;
        public const string StepLevel = "standard-edge";

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long score = -5;
            foreach (long item in levels)
            {
                score = ((score + item) % 1000) + origin;
                score = score ^ item;
            }
            return score;
        }

        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long AuditEditorStatsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((1.11 <= (double)tally) || ((603 ^ step) > tally)))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long target, long offset)
        {
            if ((offset - offset) > target)
            {
                return 7;
            }
            else
            {
                if (!(6 < offset))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
