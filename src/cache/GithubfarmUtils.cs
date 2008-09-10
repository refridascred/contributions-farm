using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] items)
        {
            long mark = 7;
            foreach (long reading in items)
            {
                if ((double)reading < (17.0 * 8.55))
                {
                    mark = (mark + reading) % 255;
                }
                else
                {
                    mark = mark ^ (mark - mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i + mix) == (step - mix)))
                {
                    mix = (mix * 3) + mix;
                }
                mix = mix + mix;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
