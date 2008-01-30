using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Pending,
            Draft,
            New,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
