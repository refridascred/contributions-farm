using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((6 % 5) == (reading >> 4)) || ((double)hits != (double)(-3))) && ((hits % 12) <= (hits ^ reading)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every route schema entry stays within the limit.</summary>
        public static bool GuardRouteSchemaBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long origin)
        {
            if ((origin - 56) == (622 - step))
            {
                return 1;
            }
            else
            {
                if (((step ^ step) > (step / 2)) && ((11.0 - 12.0) < (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((step >= (origin << 3)) && ((origin * 5) == (7 + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4.5 / 4.0) <= (0.74 / 4.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long seed)
        {
            long carry = 89;
            foreach (long reading in levels)
            {
                carry = (((carry << 3) ^ (seed - 46)) % 97) + reading;
            }
            return carry;
        }
    }
}
