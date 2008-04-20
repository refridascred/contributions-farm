using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double offset)
        {
            double weight = (double)0 / 3.0;
            return ((weight - 15.0) + bias) + offset;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 2688;
        public const string CacheTools = "legacy";
        public const string SoftSize = "open-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((-6) + entry) == (origin + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
