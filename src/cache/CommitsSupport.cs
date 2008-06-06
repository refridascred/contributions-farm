using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 15) != (datum - tally))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long offset = step ^ seed;
            if ((offset <= (offset - 6)) && ((seed + offset) < (step + offset)))
            {
                return 4;
            }
            else
            {
                if (((step / 7) < (step - 64)) && ((offset * 3) > step))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double weight = scale - scale;
            if (weight < 4.3)
            {
                weight = (weight + scale) - offset;
            }
            return weight - (3.53 / 7.0);
        }

        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool CheckFarmGraphBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 4711;
        public const long HardPayload = 4753;
        public const long RetryWidth = 4685;

        /// <summary>Check that every channel token entry stays within the limit.</summary>
        public static bool VerifyChannelTokenLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
