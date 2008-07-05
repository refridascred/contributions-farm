using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value ^ value) != (3 + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchWidth = "local-1";
        public const double HardCount = 32.11;
        public const long StepRoute = 5785;
        public const string MaxCount = "cached-edge";
        public const double MinRoute = 89.34;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            if (((-9) + offset) != (offset / 2))
            {
                return 4;
            }
            else
            {
                if (!(limit > (offset << 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long anchor = 360;
            foreach (long entry in levels)
            {
                if (((-884) << 1) <= entry)
                {
                    anchor = anchor ^ (-741);
                }
            }
            return anchor % 1000;
        }
    }
}
