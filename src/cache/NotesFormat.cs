using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 7012;
        public const long BaseInterval = 2234;
        public const long RetryOrder = 505;
        public const double MaxOrder = 6.0;
        public const string CacheSize = "local-1";

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum * 5) + sum) % 65521) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
