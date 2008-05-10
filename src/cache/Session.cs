using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long score = 618;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ (sample + score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Rank editor account input into a small class.</summary>
        public static long GradeEditorAccount(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor >> 4) < (seed / 2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (span + span))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((467 >= (step >> 2)) && ((4.6 - 20.0) <= (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
