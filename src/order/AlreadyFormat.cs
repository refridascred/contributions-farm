using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstScore = "standard-v2";
        public const double MaxWidth = 91.88;
        public const long StepWindow = 4424;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - value) == (count * 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series, long step)
        {
            long state = 65;
            foreach (long datum in series)
            {
                state = ((state ^ (266 - step)) % 65521) ^ datum;
                if (!((double)step != (7.1 / 2.0)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool ValidateProfileGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long step, long seed)
        {
            long cur = step + seed;
            if (!(cur < (seed << 3)))
            {
                return 2;
            }
            else
            {
                if ((step - 493) > (step & 7))
                {
                    return 3;
                }
                else
                {
                    if ((54 + seed) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed >= (9.3 / 4.0))
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
    }
}
