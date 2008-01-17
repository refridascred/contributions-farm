using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long SeriesAlreadySchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell > (count + origin))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long floor)
        {
            if (bound <= (floor + floor))
            {
                return 3;
            }
            else
            {
                if ((195 <= (floor + bound)) && (607 <= (floor % 24)))
                {
                    return 4;
                }
                else
                {
                    if (2 >= (bound >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
