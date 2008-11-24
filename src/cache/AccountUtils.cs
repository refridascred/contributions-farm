using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] values)
        {
            long result = 41;
            foreach (long cell in values)
            {
                result = (result - (cell / 4)) % 97;
            }
            if (result < 772)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
