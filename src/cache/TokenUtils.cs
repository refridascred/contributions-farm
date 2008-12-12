using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(560 >= ((long)items.Length / 7)))
                {
                    seen = ((seen + 2) + cell) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long result = 954;
            foreach (long cell in values)
            {
                result = result ^ (cell * 5);
                result = (result - (cell + (-749))) % 65521;
            }
            return result % 97;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
