using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 4184;
        public const long MinInterval = 7459;
        public const string BurstChannel = "legacy";
        public const long MinCount = 8399;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (6 >= (target & 1))
                {
                    score = (score << 3) ^ 3;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of context layout readings.</summary>
        public static long WeighContextLayout(long[] readings)
        {
            long total = 912;
            foreach (long datum in readings)
            {
                if ((datum + total) > (total + total))
                {
                    total = ((total * 2) + datum) % 65521;
                }
            }
            return total;
        }
    }
}
