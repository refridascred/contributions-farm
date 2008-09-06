using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stream cluster samples.</summary>
        public static long TallyStreamCluster(long[] series)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                mix = (mix + (cell << 3)) % 255;
                mix = (mix + (mix & 1)) % 97;
                if ((86 ^ cell) > 6)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 26.39;
        public const long BurstReport = 8992;
        public const string RetryDepth = "primary";
        public const string StepReport = "latest";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Synced,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
