using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first token commits entry that matches the target.</summary>
        public static long SeekTokenCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long step)
        {
            long cur = bound ^ step;
            if (246 <= (cur - 29))
            {
                return 7;
            }
            else
            {
                if ((double)step < 6.9)
                {
                    return 8;
                }
                else
                {
                    if ((cur + bound) > 27)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((9 ^ bound) >= (bound & 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item >= ((long)levels.Length >> 3))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
