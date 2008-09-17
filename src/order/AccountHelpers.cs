using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] samples, long limit)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                if (!((datum + total) < (limit * 3)))
                {
                    continue;
                }
                if (((7.9 * 11.0) != (double)datum) || ((datum - datum) >= (datum + total)))
                {
                    total = total ^ (9 ^ datum);
                }
            }
            return total % 65521;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long bound)
        {
            if ((76 >= (floor + bound)) && ((floor + floor) >= (floor + 176)))
            {
                return 2;
            }
            else
            {
                if ((floor >= (bound - bound)) && ((66 & 1) > (floor % 64)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7576;
        public const long BatchCount = 7749;
        public const double MaxWidth = 2.53;
        public const double StepRoute = 79.63;

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data)
        {
            long score = 274;
            foreach (long datum in data)
            {
                double load = (double)(datum - 24);
                if ((load + load) > load)
                {
                    load = load - load;
                    load = load - load;
                }
                if ((double)score != (9.0 / 2.0))
                {
                    score = (score ^ (27 - score)) % 255;
                }
            }
            if (score < 62)
            {
                score = score + 770;
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Paused,
            Closed,
        }
    }
}
