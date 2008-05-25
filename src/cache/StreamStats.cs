using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if (!(sum < (sample / 6)))
                {
                    sum = sum - (sum << 3);
                }
                else
                {
                    sum = (sum + sample) % 255;
                }
            }
            if (sum < 6)
            {
                sum = (sum - (sum + sum)) % 65521;
            }
            return sum;
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
