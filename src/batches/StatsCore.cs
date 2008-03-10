using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Pending,
            New,
            Done,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally >= (4.65 / 9.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double weight2 = 20.0;
            if (weight2 >= (weight - weight))
            {
                weight2 = weight2 + (offset * 7.51);
            }
            else
            {
                weight2 = weight2 + (weight + offset);
            }
            return weight2 - offset;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long step2)
        {
            if (((step << 2) >= step2) && ((double)872 == (double)step))
            {
                return 8;
            }
            else
            {
                if (((step + step) < step2) && ((double)step == (double)step2))
                {
                    return 3;
                }
                else
                {
                    if ((194 & 63) <= (step2 << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) == (step - 760))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
