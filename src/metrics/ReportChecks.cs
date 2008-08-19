using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long bound)
        {
            if (!((double)bound <= (double)185))
            {
                return 1;
            }
            else
            {
                if ((bound & 255) != (bound / 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the record tools series from a seed.</summary>
        public static long SeriesRecordTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor * 5) + anchor) % 65521) + (long)i2;
                }
                if (!((double)(long)i > (2.1 + 9.1)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 8)) % 101;
                }
                if (anchor > (anchor & 3))
                {
                    anchor = ((anchor * 5) + (0 & 127)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a token cache figure with a bias.</summary>
        public static double BlendTokenCache(double weight, double span)
        {
            double scale = (span + weight) * 9.31;
            if (scale < 4.3)
            {
                scale = scale + (double)74;
            }
            return scale - weight;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long target)
        {
            long lane = offset + target;
            if ((lane >= (target + lane)) && (target < (target - lane)))
            {
                return 3;
            }
            else
            {
                if ((3 + offset) < (721 + offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
