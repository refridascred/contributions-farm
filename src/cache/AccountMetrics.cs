using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultCount = "open-edge";
        public const double SoftRoute = 56.62;
        public const long RetryBudget = 5991;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if ((sample / 9) < (mark >> 2))
                {
                    mark = ((mark << 3) ^ (19 * 5)) % 1000;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 759)
            {
                mark = (mark * 2) + mark;
            }
            return mark;
        }

        /// <summary>Roll a window session counter forward.</summary>
        public static long RollWindowSession(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(step < (163 + 354)))
                {
                    state = ((state << 2) ^ (673 & 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Active,
            Locked,
        }
    }
}
