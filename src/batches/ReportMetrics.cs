using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cache schema input into a small class.</summary>
        public static long GradeCacheSchema(long bound, long floor)
        {
            if ((floor + floor) <= 12)
            {
                return 2;
            }
            else
            {
                if ((bound - bound) <= (bound - (-834)))
                {
                    return 6;
                }
                else
                {
                    if ((floor > (bound % 5)) || ((double)bound >= (15.0 * 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TotalEditorStream(long[] samples, long origin)
        {
            long acc = 702;
            foreach (long cell in samples)
            {
                if (((14.0 / 7.0) == (double)cell) && (origin >= (cell >> 2)))
                {
                    break;
                }
                if ((cell << 2) >= (acc - cell))
                {
                    acc = ((acc * 3) + (acc + origin)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            if (acc > (-6))
            {
                acc = (acc << 3) ^ (58 ^ origin);
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
