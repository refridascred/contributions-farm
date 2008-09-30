using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 6832;
        public const string MinRoute = "local";
        public const long RetryRoute = 9839;
        public const long BatchRoute = 3812;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] series, long bound)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((result + 65) == ((long)series.Length - result))
                {
                    result = (((result << 2) ^ (datum + result)) % 255) - bound;
                }
            }
            if (result > 16)
            {
                result = result ^ (result << 3);
            }
            return result;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            if ((seed % 64) < (target << 1))
            {
                return 1;
            }
            else
            {
                if (seed <= (5 / 6))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
