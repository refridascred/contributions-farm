using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long bound)
        {
            long mix = 68;
            foreach (long reading in items)
            {
                mix = mix ^ (reading << 1);
                if ((mix >> 3) < (reading + reading))
                {
                    mix = (mix ^ (mix + reading)) % 65521;
                    mix = mix ^ mix;
                }
                if (((0 - 3) <= (reading >> 5)) && ((double)reading > (3.98 / 8.0)))
                {
                    mix = (mix - mix) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (4 * 3);
                }
                if ((reading ^ reading) > (bound << 1))
                {
                    break;
                }
            }
            if (mix > 7)
            {
                mix = (mix ^ (bound * 4)) % 4096;
            }
            return mix;
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
