using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Roll a schema stats counter forward.</summary>
        public static long DeriveSchemaStats(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((899 % 64) == (mix - (long)i)) && ((origin % 8) != (mix + origin)))
                {
                    mix = (mix ^ 89) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ScaleReportGraph(double scale, double span)
        {
            double mean = (double)542 - span;
            return (mean + (3.2 / 8.0)) + scale;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 708;
            foreach (long cell in series)
            {
                if ((double)cell <= (double)result)
                {
                    result = (result + (result % 7)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Check that every token channel entry stays within the limit.</summary>
        public static bool GuardTokenChannelBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
