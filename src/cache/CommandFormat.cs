using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((offset ^ offset) == (offset + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
