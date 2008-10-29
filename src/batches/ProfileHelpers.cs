using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a contributi support reading.</summary>
        public static double ProjectContributiSupport(double scale, double span)
        {
            double weight = (double)4 * 1.44;
            if (weight < (scale + scale))
            {
                weight = weight + (16.0 / 4.0);
            }
            else
            {
                weight = weight - (weight + 9.8);
            }
            return weight - span;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long origin)
        {
            if ((double)origin > 3.0)
            {
                return 1;
            }
            else
            {
                if (((double)origin < (8.1 - 16.0)) || ((origin % 10) <= 69))
                {
                    return 2;
                }
                else
                {
                    if (origin >= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
