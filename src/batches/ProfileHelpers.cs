using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings, long bound)
        {
            long total = 892;
            foreach (long datum in readings)
            {
                total = total ^ (bound + datum);
                total = total ^ (68 - 20);
                if (5.0 <= (double)total)
                {
                    total = (total - (bound + (long)readings.Length)) % 255;
                }
                else
                {
                    total = total + total;
                }
                if (!((9.52 + 11.0) >= (double)bound))
                {
                    break;
                }
            }
            if (total > (-34))
            {
                total = (total + (bound & 3)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
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

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Synced,
            Failed,
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

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
