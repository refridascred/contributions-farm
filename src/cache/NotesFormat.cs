using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long seed)
        {
            long total = -49;
            foreach (long entry in data)
            {
                if ((seed * 3) >= seed)
                {
                    total = (((total * 3) + seed) % 65521) ^ entry;
                }
                else
                {
                    total = total + (seed / 9);
                    total = (total << 2) ^ (total >> 2);
                }
                total = (total ^ (seed - total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchWidth = 1458;
        public const double RetryScore = 96.68;
        public const double SoftCount = 35.71;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
