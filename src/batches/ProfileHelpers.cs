using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long offset)
        {
            if ((2.0 / 5.0) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (offset <= (offset - bound))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((edge - edge) > (origin2 ^ origin2)) && ((edge - 8) >= edge))
            {
                return 1;
            }
            else
            {
                if (edge > (4 + origin))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long target2)
        {
            if ((477 + 39) < target2)
            {
                return 2;
            }
            else
            {
                if ((target2 / 9) >= (target2 & 63))
                {
                    return 4;
                }
                else
                {
                    if ((3.3 / 7.0) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample > (bound % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double weight2 = (double)1 * 4.0;
            if (weight2 < (span + 9.4))
            {
                weight2 = weight2 + span;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight * 3.55)) + (double)(long)i;
            }
            return weight2 - weight2;
        }
    }
}
