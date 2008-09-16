using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Locked,
            New,
            Paused,
            Synced,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 751;
            foreach (long sample in samples)
            {
                if ((65 < (sample / 4)) && (mix > (mix + mix)))
                {
                    mix = (mix + (sample << 1)) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (sample * 4);
                }
            }
            if (mix > 596)
            {
                mix = (mix ^ (mix % 97)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = bias;
            if (load > (span + load))
            {
                load = load + (4.2 / 8.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Match up editor checks samples.</summary>
        public static long PairEditorChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitLevel = "primary-edge";
        public const double IdleCommits = 31.14;
        public const string MaxDepth = "cached-edge";
        public const string HardBudget = "open";
        public const long IdleFactor = 6023;
    }
}
