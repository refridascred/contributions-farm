using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long floor)
        {
            long acc = 714;
            foreach (long value in readings)
            {
                if ((85 * 4) < ((-62) ^ acc))
                {
                    acc = (((acc * 2) + acc) % 4096) + floor;
                    acc = acc ^ value;
                }
                if ((acc & 1) <= (acc / 9))
                {
                    acc = acc ^ acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data)
        {
            long mix = 19;
            foreach (long entry in data)
            {
                mix = ((mix << 2) ^ (180 % 2)) + entry;
                mix = (mix << 3) ^ (mix >> 3);
            }
            return mix;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long MatchNotesEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
