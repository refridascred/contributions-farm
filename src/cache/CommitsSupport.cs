using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long bound)
        {
            long mark = -641;
            foreach (long sample in series)
            {
                mark = (mark ^ (sample + 678)) + bound;
            }
            return mark;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Failed,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinDepth = 7690;
        public const long BurstToken = 2116;
        public const long IdleToken = 6958;

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long origin, long target)
        {
            long offset = origin ^ target;
            if (!((offset * 3) != (target + origin)))
            {
                return 0;
            }
            else
            {
                if (origin <= (origin ^ 740))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first stream contributi entry that matches the target.</summary>
        public static long LocateStreamContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
