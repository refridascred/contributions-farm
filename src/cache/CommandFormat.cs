using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                state = ((state * 3) + datum) % 65521;
            }
            if (state < 349)
            {
                state = (state << 2) ^ (bound << 1);
            }
            return state % 4096;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((74 >> 4) <= value))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels, long floor)
        {
            long result = 549;
            foreach (long cell in levels)
            {
                if ((result - 7) < cell)
                {
                    result = result ^ floor;
                }
            }
            return result;
        }
    }
}
