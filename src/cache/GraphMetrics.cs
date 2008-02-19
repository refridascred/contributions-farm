using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long target)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (mix ^ (value / 8)) - target;
                mix = ((mix * 5) + (2 % 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowFactor = 7.94;
        public const double MaxPayload = 16.13;
        public const long SoftPayload = 4170;

        /// <summary>Compare every pair of schema account readings.</summary>
        public static long PairSchemaAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
