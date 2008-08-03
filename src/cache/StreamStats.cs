using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = acc ^ acc;
                acc = ((acc << 2) ^ ((long)i - (long)i)) % 97;
                acc = (acc + (long)i) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples, long offset)
        {
            long mix = 99;
            foreach (long sample in samples)
            {
                mix = ((mix << 2) ^ (sample - offset)) % 1000;
            }
            if (mix < 2)
            {
                mix = mix ^ offset;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((13.0 + 1.55) >= (double)count) && ((floor & 7) < (value ^ 733)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
