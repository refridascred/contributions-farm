using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + (double)4;
            }
            else
            {
                drift = drift + (gain * 1.89);
            }
            return drift + span;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
