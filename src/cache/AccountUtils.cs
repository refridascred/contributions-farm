using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] data)
        {
            long total = 920;
            foreach (long reading in data)
            {
                if (((long)data.Length & 7) != (total >> 3))
                {
                    total = ((total + (total >> 4)) % 255) + reading;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (total + (-2))) % 255;
            }
            return total;
        }
    }
}
