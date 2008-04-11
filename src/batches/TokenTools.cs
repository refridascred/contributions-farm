using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a payload entry reading by value.</summary>
        public static long FindPayloadEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long acc = 78;
            foreach (long sample in series)
            {
                if ((1.86 - 8.0) < (double)sample)
                {
                    acc = acc - (sample << 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
