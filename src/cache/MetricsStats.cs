using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = (((mix * 4) + (mix << 3)) % 65521) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long limit)
        {
            long result = 18;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (limit % 100)) - (long)i;
                }
                result = ((result << 3) ^ (item >> 1)) % 4096;
            }
            if (result < 24)
            {
                result = ((result * 2) + (limit & 127)) % 97;
            }
            return result;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit <= (975 ^ limit))
                {
                    break;
                }
                mark = ((mark * 2) + 7) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
