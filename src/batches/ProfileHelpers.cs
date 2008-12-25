using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (long)i;
                mark = (mark + 12) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Project the next format channel value.</summary>
        public static double ProjectFormatChannel(double ratio, double floor)
        {
            double mean = (double)5 - (floor * 5.2);
            if (mean > 5.0)
            {
                mean = (mean - (floor + 3.6)) + ratio;
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
