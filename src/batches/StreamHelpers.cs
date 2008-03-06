using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a tools command reading.</summary>
        public static double ScaleToolsCommand(double weight, double span)
        {
            double load = span * 7.32;
            return (load + 1.32) + weight;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next channel token value.</summary>
        public static double AdjustChannelToken(double weight, double floor)
        {
            double load = (double)(774 + (-6));
            if (load > load)
            {
                load = (load + weight) - floor;
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - 5.2) - (double)(long)i;
            }
            return load - (8.5 - weight);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Idle,
            New,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long step)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                mark = ((mark * 4) + (step >> 2)) % 65521;
                if (((step & 15) != (step / 4)) && ((0.8 - 1.68) >= (double)mark))
                {
                    mark = (mark << 3) ^ step;
                }
                if (((mark ^ sample) < (step + mark)) || (44 <= mark))
                {
                    mark = ((mark << 3) ^ step) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
