using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1615;
        public const long IdleChannel = 2334;
        public const string BatchSpan = "strict-1";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) >= (count ^ count))
                {
                    count = (count + 1) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph order samples.</summary>
        public static long WeighGraphOrder(long[] levels, long floor)
        {
            long total = 56;
            foreach (long entry in levels)
            {
                total = ((total ^ 968) - entry) - floor;
            }
            if (total < 376)
            {
                total = (total + (total - total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
