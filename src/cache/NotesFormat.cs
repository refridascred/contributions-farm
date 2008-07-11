using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double offset)
        {
            double gain = ratio / 5.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - gain) + (double)(long)i) + offset;
            }
            return gain + 14.0;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
