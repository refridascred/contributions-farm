using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long mix = 790;
            foreach (long entry in readings)
            {
                if (mix <= (mix - seed))
                {
                    mix = mix ^ entry;
                    mix = ((mix << 2) ^ (seed - seed)) % 255;
                }
                mix = mix ^ 99;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 8166;
        public const string MinSize = "primary-edge";
        public const long LimitFormat = 1564;
        public const string StepLevel = "local-edge";
        public const string IdleFormat = "strict-v2";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up context buffer samples.</summary>
        public static long OverlapContextBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
