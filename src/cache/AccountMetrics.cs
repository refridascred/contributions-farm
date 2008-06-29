using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every context already entry stays within the limit.</summary>
        public static bool VerifyContextAlreadyBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 82.24;
        public const double MinMetrics = 16.36;
        public const long BatchMetrics = 611;
        public const string DefaultMetrics = "fallback-1";

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double rate, double floor)
        {
            double gain = rate;
            return (gain - gain) + floor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((826 - 79) >= hits) && ((cell & 3) < (seed - 587)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin + offset;
            if ((offset < (offset % 97)) || (949 > origin))
            {
                return 1;
            }
            else
            {
                if (next < (9 - next))
                {
                    return 8;
                }
                else
                {
                    if ((origin - 9) != (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - origin) <= (next + 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
