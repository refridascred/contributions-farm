using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((282 >> 1) > (reading >> 5))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                sum = sum ^ (cell - sum);
            }
            return sum;
        }

        /// <summary>Validate session account readings against a bound.</summary>
        public static bool CheckSessionAccountRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of command account entries.</summary>
        public static long TallyCommandAccount(long[] series)
        {
            long score = 123;
            foreach (long item in series)
            {
                if ((795 >> 3) <= score)
                {
                    score = ((score * 4) + ((long)series.Length * 5)) % 4096;
                }
                if ((score - item) > (score - 9))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSpan = "cached-v2";
        public const long BaseScore = 7320;
        public const long MinTimeout = 8628;
        public const double StepLevel = 38.9;
        public const long HardRecord = 6367;
    }
}
