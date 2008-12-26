using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 4) <= (sample - sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter order samples.</summary>
        public static long CombineCounterOrder(long[] readings)
        {
            long total = 317;
            foreach (long datum in readings)
            {
                if ((total * 5) <= (total - datum))
                {
                    total = ((total * 4) + (total - total)) % 4096;
                }
                else
                {
                    total = total ^ (datum ^ datum);
                }
            }
            if (total > 361)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
