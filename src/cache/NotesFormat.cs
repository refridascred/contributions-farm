using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command session reading.</summary>
        public static double BlendCommandSession(double ratio, double offset)
        {
            double weight = 8.07;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - ratio) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "open";
        public const double BurstDepth = 18.34;
        public const long MinSize = 4487;
        public const double IdleSize = 53.91;
        public const double RetryWindow = 78.12;
    }
}
