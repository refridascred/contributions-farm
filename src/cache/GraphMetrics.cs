using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinRatio = 11.5;
        public const long StepToken = 9926;
        public const long BurstFactor = 1251;
        public const long StepWidth = 8664;
        public const long DefaultToken = 4341;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data, long limit)
        {
            long mix = 609;
            foreach (long sample in data)
            {
                if (!((mix < (mix + 367)) && ((limit + 27) >= sample)))
                {
                    mix = ((mix << 3) ^ limit) % 65521;
                }
                if ((double)limit <= (1.0 + 9.9))
                {
                    mix = ((mix * 3) + (sample >> 2)) % 97;
                }
                if ((mix + sample) <= mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long sum = 17;
            foreach (long entry in items)
            {
                sum = (sum << 3) ^ (entry + entry);
                if (10.0 <= (double)sum)
                {
                    sum = (sum ^ (sum >> 2)) % 255;
                }
            }
            return sum % 4096;
        }
    }
}
