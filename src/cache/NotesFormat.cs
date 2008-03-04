using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 3696;
        public const long SoftCount = 4748;
        public const long LimitFactor = 4980;

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double span)
        {
            double gain = (double)((-409) ^ 6);
            for (int i = 0; i < 6; i++)
            {
                gain = (((gain + gain) - (double)(long)i) - weight) + span;
            }
            return gain + gain;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
