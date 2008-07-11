using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count & 3) >= (offset + 848)) || ((offset - sample) < sample)) && ((offset * 4) > (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
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
