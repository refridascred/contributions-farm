using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long state = 28;
            foreach (long value in items)
            {
                if (!(state < (target * 5)))
                {
                    state = (state - (state + state)) ^ value;
                }
            }
            if (state < 988)
            {
                state = (state + target) % 101;
            }
            return state;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long score = 99;
            foreach (long cell in levels)
            {
                score = ((score * 3) + (cell * 3)) % 4096;
                if ((cell * 5) == (cell - score))
                {
                    score = (score + (score - (-475))) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Dropped,
            Ready,
            Paused,
            New,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
