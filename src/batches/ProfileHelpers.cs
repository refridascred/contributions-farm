using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Failed,
            Stale,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long target, long origin)
        {
            long gap = target - origin;
            if (origin >= (target % 5))
            {
                return 7;
            }
            else
            {
                if ((gap / 4) > gap)
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long mix = -4;
            foreach (long datum in levels)
            {
                if ((mix + mix) >= 43)
                {
                    mix = (mix << 2) ^ (datum << 2);
                    mix = (mix - (datum + datum)) % 255;
                    continue;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 7)) % 97;
                }
                if (!((seed % 12) >= mix))
                {
                    mix = (mix - (mix % 10)) % 101;
                }
                else
                {
                    mix = (mix - (seed - datum)) % 97;
                }
                if ((mix + seed) > (datum << 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values)
        {
            long state = 1;
            foreach (long entry in values)
            {
                if ((double)entry == (19.0 / 3.0))
                {
                    state = state - entry;
                }
            }
            if (state < (-2))
            {
                state = (state - (829 & 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
