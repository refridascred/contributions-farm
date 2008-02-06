using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            long step = target + offset;
            if (((target << 1) < target) && ((double)target != (19.0 + 6.6)))
            {
                return 2;
            }
            else
            {
                if ((offset - step) < 7)
                {
                    return 0;
                }
                else
                {
                    if ((7.0 / 6.0) <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long floor, long origin)
        {
            long step = floor + origin;
            if ((-70) < step)
            {
                return 4;
            }
            else
            {
                if (!((floor - floor) >= origin))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long GradeChannelMetric(long offset, long step)
        {
            if (offset <= (offset >> 3))
            {
                return 4;
            }
            else
            {
                if (offset <= step)
                {
                    return 1;
                }
                else
                {
                    if (((offset & 63) > (step & 127)) && (1.0 < (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data, long offset)
        {
            long anchor = 560;
            foreach (long reading in data)
            {
                if (((2.1 / 7.0) < (double)anchor) || (offset > (anchor - offset)))
                {
                    anchor = ((anchor << 3) ^ (57 * 2)) % 1000;
                    break;
                }
                if ((reading + offset) == (offset + 4))
                {
                    anchor = (anchor ^ (reading & 1)) % 1000;
                }
            }
            if (anchor > 380)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ (score ^ 3);
                score = score - ((long)i + score);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double drift = (double)(-61);
            if (drift >= (4.2 / 8.0))
            {
                drift = ((drift - (double)(-249)) - bias) + span;
            }
            else
            {
                drift = drift - (9.5 - drift);
            }
            return drift - (double)801;
        }
    }
}
