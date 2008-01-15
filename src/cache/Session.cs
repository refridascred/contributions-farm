using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 5063;
        public const double SoftReport = 98.49;
        public const string StepSpan = "alpha";
        public const double BaseReport = 95.07;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((3.67 / 9.0) == (double)(long)i)
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long step)
        {
            if (((floor + floor) > 530) || ((floor / 4) == (step >> 4)))
            {
                return 7;
            }
            else
            {
                if ((floor - step) <= (step + floor))
                {
                    return 3;
                }
                else
                {
                    if (((-4) + step) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
