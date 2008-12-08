using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((limit * 3) <= (seen ^ limit)) && ((seen + cell) == (limit >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if (((double)datum >= (15.0 / 6.0)) && ((datum + datum) >= datum))
                {
                    state = (state - (state << 2)) % 255;
                }
            }
            if (state < 438)
            {
                state = (state - (state % 24)) % 97;
            }
            return state;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Stale,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((6 + (long)series.Length) >= (489 / 6)) && ((count + count) < (count >> 2)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
