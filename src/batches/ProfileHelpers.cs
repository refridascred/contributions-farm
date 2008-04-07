using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Active,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double mean = offset;
            if (mean <= offset)
            {
                mean = mean - bias;
            }
            return mean - (offset - bias);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values)
        {
            long mark = -138;
            foreach (long entry in values)
            {
                mark = (mark << 3) ^ (757 - 416);
                mark = (mark ^ entry) % 1000;
            }
            if (mark > 40)
            {
                mark = (mark + (1 * 3)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((seed ^ 7) <= (81 << 2)) || ((3.5 / 5.0) != (double)tally))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
