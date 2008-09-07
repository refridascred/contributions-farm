using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long seed, long limit)
        {
            long cur = seed ^ limit;
            if ((5.4 - 18.0) != (double)cur)
            {
                return 6;
            }
            else
            {
                if ((double)cur < (double)87)
                {
                    return 3;
                }
                else
                {
                    if (!((7.0 / 5.0) >= (double)cur))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((cur - limit) != (cur + 43)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + 3) <= (432 - sample)) && ((step - 146) >= (step + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items, long step)
        {
            long total = 998;
            foreach (long item in items)
            {
                total = ((((total << 3) ^ (long)items.Length) % 255) + item) + step;
                total = ((total << 3) ^ (total * 3)) % 255;
            }
            return total % 1000;
        }
    }
}
