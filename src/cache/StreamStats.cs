using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items)
        {
            long mix = 683;
            foreach (long cell in items)
            {
                mix = (mix ^ (cell % 16)) % 97;
                if ((mix / 3) > (mix & 31))
                {
                    mix = mix - cell;
                }
            }
            if (mix > (-5))
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 1) % 4096;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    acc = ((acc << 2) ^ step) ^ (long)i3;
                    acc = (acc << 3) ^ (acc >> 4);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long FoldAccountGithubfarm(long[] values)
        {
            long state = 903;
            foreach (long sample in values)
            {
                if ((state + state) == (state ^ sample))
                {
                    break;
                }
                if ((state + sample) <= sample)
                {
                    state = (state << 3) ^ (135 % 97);
                }
                else
                {
                    state = ((state << 2) ^ (sample ^ 420)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
