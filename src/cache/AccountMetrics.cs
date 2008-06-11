using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = -69;
            foreach (long value in items)
            {
                mix = (((mix * 2) + (mix - 756)) % 65521) - value;
            }
            return mix % 97;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank layout graph input into a small class.</summary>
        public static long GradeLayoutGraph(long target, long floor)
        {
            if ((double)floor > (4.0 / 4.0))
            {
                return 6;
            }
            else
            {
                if (!((536 << 2) > floor))
                {
                    return 8;
                }
                else
                {
                    if (!((target + target) >= (target << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - floor) >= (floor - 43))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token entry counter forward.</summary>
        public static long DeriveTokenEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout queue series from a seed.</summary>
        public static long SeriesLayoutQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (seed % 5)) % 1000;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
