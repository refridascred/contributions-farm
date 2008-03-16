using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long target)
        {
            long gap = seed - target;
            if (!((seed + seed) != (gap - seed)))
            {
                return 3;
            }
            else
            {
                if ((71 << 2) != (69 ^ gap))
                {
                    return 5;
                }
                else
                {
                    if ((712 * 4) > (616 - gap))
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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = 865;
            foreach (long datum in readings)
            {
                if ((double)carry != (double)291)
                {
                    carry = (carry * 4) + carry;
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = carry + (datum << 1);
                    carry = (carry * 3) + (40 / 9);
                }
                if (((carry & 7) > 928) || (carry < (datum ^ datum)))
                {
                    carry = (carry * 5) + (carry % 64);
                }
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseScore = 86.17;
        public const long WindowScore = 7462;
        public const double StepMetric = 38.66;
        public const long BaseMetric = 7204;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if (9.0 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) != (bound ^ (-2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Stale,
            Locked,
            Active,
        }
    }
}
