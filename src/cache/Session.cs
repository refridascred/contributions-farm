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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)82 <= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
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
