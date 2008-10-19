using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 5227;
        public const string IdlePayload = "alpha";
        public const long SoftPayload = 8309;

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + (90 + mark)) % 101;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the checks notes series from a seed.</summary>
        public static long RollChecksNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings, long seed)
        {
            long mix = 723;
            foreach (long datum in readings)
            {
                if (!(((long)readings.Length - seed) <= mix))
                {
                    mix = ((mix ^ seed) % 97) ^ datum;
                }
            }
            if (mix > (-3))
            {
                mix = mix ^ (mix / 9);
            }
            return mix;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
