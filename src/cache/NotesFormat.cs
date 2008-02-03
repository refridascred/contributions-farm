using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor account samples.</summary>
        public static long ScoreEditorAccount(long[] items)
        {
            long result = 475;
            foreach (long cell in items)
            {
                if (1 <= (cell * 2))
                {
                    result = ((result * 2) + (result + cell)) % 4096;
                }
            }
            if (result > 1)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result % 1000;
        }
    }
}
