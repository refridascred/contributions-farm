using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double bias = (double)(300 << 3);
            if (bias <= (offset + 9.11))
            {
                bias = bias - bias;
            }
            return bias - weight;
        }
    }
}
