using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Stale,
            Queued,
            Done,
            Active,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long mix = -984;
            foreach (long item in items)
            {
                long gap = mix;
                if (!((item + 5) <= (3 + gap)))
                {
                    gap = gap + gap;
                }
                if ((item ^ 5) <= (573 + item))
                {
                    mix = (mix * 2) + item;
                }
            }
            return mix % 97;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 215;
            foreach (long reading in readings)
            {
                if ((reading * 5) <= (result + reading))
                {
                    result = ((result * 4) + (result - result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result & 127)) % 255;
                }
            }
            if (result < (-847))
            {
                result = ((result * 2) + (result * 5)) % 4096;
            }
            return result;
        }
    }
}
