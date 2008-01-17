using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first metrics command entry that matches the target.</summary>
        public static long SeekMetricsCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = score ^ ((long)i - floor);
                score = (score << 2) ^ (score + floor);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Rank cluster route input into a small class.</summary>
        public static long SortClusterRoute(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((limit >= (step * 2)) || ((double)limit == (double)seed))
            {
                return 3;
            }
            else
            {
                if ((8 - limit) <= (61 & 63))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((577 + seen) == (sample - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Done,
            Active,
        }
    }
}
