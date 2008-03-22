using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 6750;
        public const long IdleInterval = 9760;
        public const long BurstSupport = 4118;
        public const long BatchSupport = 9809;
        public const long SoftBudget = 6802;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings, long limit)
        {
            long score = 87;
            foreach (long item in readings)
            {
                if (((score - score) < (limit * 2)) && ((77 - item) != (item * 4)))
                {
                    score = (score * 2) + (score + item);
                }
            }
            return score;
        }
    }
}
