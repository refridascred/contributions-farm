using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Closed,
            New,
            Active,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Retry,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long acc = 30;
            foreach (long reading in samples)
            {
                acc = ((acc * 3) + acc) % 65521;
                if ((acc >= (long)samples.Length) && (reading >= (acc + 0)))
                {
                    acc = acc + (acc + reading);
                }
            }
            return acc % 65521;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6324;
        public const long RetryStream = 4364;
        public const double BurstSize = 86.38;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((9.31 * 4.0) != (double)(long)i)
                {
                    mix = (mix - ((long)i >> 2)) % 97;
                    mix = (mix + (long)i) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
