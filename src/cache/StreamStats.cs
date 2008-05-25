using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
            public long Token { get; set; }
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
