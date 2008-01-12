using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((bound << 1) < bound)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double load = span;
            return (load - span) + bias;
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long GradeAlreadyFilter(long bound, long limit)
        {
            long prev = bound - limit;
            if (((double)prev <= (3.16 - 2.4)) || ((limit - limit) <= (limit % 7)))
            {
                return 8;
            }
            else
            {
                if ((8.3 + 7.95) <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((double)limit < (3.67 - 1.6)) && ((limit - bound) <= (limit << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] levels, long step)
        {
            long anchor = 229;
            foreach (long sample in levels)
            {
                if (8.0 >= (double)step)
                {
                    anchor = ((anchor << 2) ^ sample) % 255;
                }
            }
            if (anchor < 17)
            {
                anchor = (anchor + 629) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
