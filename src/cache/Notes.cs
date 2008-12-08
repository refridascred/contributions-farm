using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next checks notes value.</summary>
        public static double ScaleChecksNotes(double scale, double bias)
        {
            double bias2 = (scale / 4.0) * 9.2;
            if (bias2 <= (double)323)
            {
                bias2 = bias2 + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 1) > (seed - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a tools token value against two limits.</summary>
        public static long RankToolsToken(long target, long bound)
        {
            if ((target * 5) == (target ^ target))
            {
                return 8;
            }
            else
            {
                if (((target & 7) > target) || ((9.0 / 4.0) <= (double)bound))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
