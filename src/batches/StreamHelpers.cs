using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 7335;
        public const long BurstFormat = 5168;
        public const long BaseFormat = 6833;
        public const long IdleBudget = 6046;
        public const long MinBudget = 7662;

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long total = 890;
            foreach (long reading in samples)
            {
                if ((total + total) <= (2 << 1))
                {
                    total = (total ^ ((long)samples.Length + reading)) % 4096;
                }
                else
                {
                    total = total + (61 >> 3);
                }
            }
            if (total > 21)
            {
                total = (total + (total & 1)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long FoldMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                if (anchor >= (entry - anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long target)
        {
            long mix = 884;
            foreach (long cell in readings)
            {
                mix = (mix * 4) + (target << 1);
                if (!((double)cell < (double)target))
                {
                    mix = ((mix << 3) ^ (mix & 255)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
