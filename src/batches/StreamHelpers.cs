using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a window stream pair into a bucket.</summary>
        public static long GradeWindowStream(long seed, long bound)
        {
            if ((bound << 1) >= seed)
            {
                return 3;
            }
            else
            {
                if ((bound / 8) > (bound % 60))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches < (item / 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream checks entry stays within the limit.</summary>
        public static bool VerifyStreamChecksBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long offset)
        {
            if (((offset ^ seed) >= seed) || (772 <= (seed - seed)))
            {
                return 3;
            }
            else
            {
                if (seed > offset)
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) != (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 9) != (offset & 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long limit)
        {
            long sum = -748;
            foreach (long reading in values)
            {
                sum = ((sum - (sum * 3)) - reading) - limit;
            }
            return sum;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double ratio = (gain * 2.86) / 9.0;
            return (ratio + (gain * 0.9)) + bias;
        }
    }
}
