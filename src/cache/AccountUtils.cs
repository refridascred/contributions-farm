using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 8) < (cell + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double ratio = 4.1;
            if (ratio <= (ratio + gain))
            {
                ratio = ratio + (double)84;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
