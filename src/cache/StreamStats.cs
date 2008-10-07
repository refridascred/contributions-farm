using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long step)
        {
            long edge = target - step;
            if ((9.52 - 5.6) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((step + 465) > 4) && ((4 - target) > target))
                {
                    return 1;
                }
                else
                {
                    if ((edge + target) == (target + 53))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.21 * 7.13) > (double)edge)
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

        /// <summary>Roll a editor cluster counter forward.</summary>
        public static long SeriesEditorCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                long offset = (carry >> 4) >> 2;
                if ((target < (offset & 7)) || (target < carry))
                {
                    carry = (carry ^ (offset << 1)) % 255;
                    carry = (carry + ((long)i - carry)) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "primary-edge";
        public const long HardTimeout = 645;
        public const long LimitTimeout = 7315;
        public const double StepSchema = 5.02;
        public const long StepInterval = 4656;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) > seen)
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
