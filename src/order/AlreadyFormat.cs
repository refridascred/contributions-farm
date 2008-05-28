using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= (227 >> 1))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long step)
        {
            long step2 = bound - step;
            if ((19.0 * 15.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (step < 13)
                {
                    return 4;
                }
                else
                {
                    if (66 < (step2 + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long bound)
        {
            if (9.0 <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (((offset % 7) < 4) && (354 > (49 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((18.0 > (double)offset) && ((bound ^ offset) < (offset + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound / 7) != (offset + offset)) || (bound < (1 << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ ((long)i / 8);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long score = 592;
            foreach (long sample in series)
            {
                score = (((score << 3) ^ score) - sample) - target;
            }
            return score % 65521;
        }
    }
}
