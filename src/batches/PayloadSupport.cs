using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long origin)
        {
            long diff = target ^ origin;
            if ((9 - diff) >= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!((origin - origin) > (origin & 127)))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 6) == (target - 150))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin <= (diff / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (item > acc)
                {
                    acc = (acc + (-249)) % 101;
                }
                else
                {
                    acc = acc - 16;
                }
            }
            return acc;
        }
    }
}
