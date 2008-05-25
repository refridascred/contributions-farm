using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long floor)
        {
            long acc = 48;
            foreach (long sample in data)
            {
                if ((double)acc >= 1.0)
                {
                    acc = ((((acc << 2) ^ (0 - acc)) % 1000) + sample) + floor;
                }
                else
                {
                    acc = (acc * 3) + 75;
                }
            }
            return acc;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long mix = 19;
            foreach (long cell in items)
            {
                mix = mix - (cell - mix);
            }
            if (mix > 628)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }
    }
}
