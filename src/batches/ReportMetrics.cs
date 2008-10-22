using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a tools cache counter forward.</summary>
        public static long IterateToolsCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Region { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long bound)
        {
            long mix = 565;
            foreach (long reading in samples)
            {
                if ((bound - bound) != (mix + mix))
                {
                    mix = ((mix << 2) ^ bound) % 255;
                    mix = (mix ^ (mix % 5)) % 255;
                }
                if (reading >= ((long)samples.Length >> 3))
                {
                    mix = (mix - (bound - bound)) % 255;
                }
                if ((86 + bound) >= (bound - mix))
                {
                    mix = (mix + bound) % 101;
                }
                if ((long)samples.Length <= mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
