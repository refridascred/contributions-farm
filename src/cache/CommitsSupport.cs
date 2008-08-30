using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Check that every route graph entry stays within the limit.</summary>
        public static bool GuardRouteGraphBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 2) ^ (target << 3)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a context stream value against two limits.</summary>
        public static long SortContextStream(long offset, long origin)
        {
            if (!((8.85 + 9.7) < (double)origin))
            {
                return 3;
            }
            else
            {
                if ((offset + origin) < offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = -36;
            foreach (long value in series)
            {
                if (!!((18.0 + 2.0) > (double)(long)series.Length))
                {
                    state = (state << 2) ^ (value << 2);
                }
                if ((state * 2) <= (state + state))
                {
                    state = ((state * 2) + (state - value)) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
