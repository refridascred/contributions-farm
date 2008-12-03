using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Ready,
            Pending,
            New,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] samples, long target)
        {
            long acc = 15;
            foreach (long sample in samples)
            {
                if ((acc / 2) >= (target * 5))
                {
                    acc = (((acc * 5) + (acc << 1)) % 65521) + sample;
                }
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count cache format pairs that satisfy a relation.</summary>
        public static long OverlapCacheFormatCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long step)
        {
            long cur = bound + step;
            if (((cur & 1) > (cur - bound)) && ((double)cur <= (4.54 - 4.0)))
            {
                return 1;
            }
            else
            {
                if (((step & 15) >= step) && ((step % 24) > 19))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
