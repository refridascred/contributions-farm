using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double ratio = (double)(57 + 8);
            if (ratio >= (weight / 5.0))
            {
                ratio = (ratio + ratio) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (double)43;
        }

        /// <summary>Iterate the support format series from a seed.</summary>
        public static long RollSupportFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state + 938) % 101;
                if (state < (state - state))
                {
                    state = (state + (limit / 9)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state * 5) + limit) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next already metric value from a seed.</summary>
        public static long RollAlreadyMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((0.7 / 8.0) > (7.27 / 9.0))
                {
                    carry = (carry - ((long)i / 9)) % 97;
                }
                carry = (carry ^ ((-404) % 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
