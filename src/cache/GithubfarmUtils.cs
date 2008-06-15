using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result + ((long)i + origin);
                if ((791 + origin) < (origin * 2))
                {
                    long matches = (origin - (-83)) >> 2;
                    result = (result ^ matches) % 65521;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 2) == (target + target))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value >= (count * 5)) && !((double)value > (double)target))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
