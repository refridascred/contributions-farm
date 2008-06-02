using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = (double)8 * 4.7;
            if (load >= (1.5 - gain))
            {
                load = load + load;
            }
            else
            {
                load = load + (gain - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (gain + load)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long TallyProfileCache(long[] readings)
        {
            long sum = 632;
            foreach (long datum in readings)
            {
                if (((datum + 7) > (sum & 31)) || ((3.46 + 3.9) != (double)datum))
                {
                    sum = ((sum * 4) + (datum / 3)) % 101;
                }
            }
            if (sum > 1)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
