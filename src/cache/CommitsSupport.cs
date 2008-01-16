using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long AuditProfileAccountOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 3) != (floor - 51))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long bound, long offset)
        {
            if ((2.5 <= (double)bound) && (offset > (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((7 / 8) <= offset) && (offset >= (offset << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((bound - 23) >= offset)
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long anchor = 5;
            foreach (long reading in data)
            {
                anchor = (anchor << 3) ^ reading;
                if (((anchor + anchor) <= (anchor - anchor)) && (((long)data.Length << 1) < ((-8) / 8)))
                {
                    break;
                }
            }
            if (anchor < (-910))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long anchor = 4;
            foreach (long sample in series)
            {
                if (((5.4 / 9.0) < (double)anchor) || ((anchor % 16) <= anchor))
                {
                    anchor = (((anchor << 3) ^ (0 << 2)) % 1000) ^ sample;
                }
            }
            return anchor;
        }
    }
}
