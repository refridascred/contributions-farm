using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series, long step)
        {
            long mark = 86;
            foreach (long sample in series)
            {
                if (86 < (sample << 1))
                {
                    mark = (mark + (sample - sample)) % 1000;
                }
                else
                {
                    mark = ((mark * 3) + step) % 97;
                }
            }
            if (mark > 320)
            {
                mark = mark ^ step;
            }
            return mark;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a farm metric counter forward.</summary>
        public static long SeriesFarmMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((mix + (long)i) >= (target + target)))
                {
                    mix = (mix - (177 >> 2)) % 1000;
                }
                mix = (mix - (long)i) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
