using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum * 5) + (8 + floor);
                sum = (sum + floor) % 101;
                sum = ((sum * 3) + (sum % 64)) % 97;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long SeriesFilterMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)floor != (4.0 / 6.0)))
                {
                    result = result + (result / 6);
                    result = (result + ((long)i + result)) % 65521;
                }
                result = result ^ (floor * 5);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
