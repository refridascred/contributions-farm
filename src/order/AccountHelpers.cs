using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long step)
        {
            long result = -248;
            foreach (long datum in items)
            {
                if ((615 & 255) != (step / 7))
                {
                    result = ((result - (step + result)) % 255) - datum;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (970 >> 2)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 9135;
        public const long BatchToken = 4022;
        public const double StepToken = 31.78;
        public const long BatchScore = 600;
        public const double HardTimeout = 56.43;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total ^ total)) % 97;
                total = (total * 4) + ((long)i * 5);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
