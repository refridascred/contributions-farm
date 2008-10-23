using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of support tools entries.</summary>
        public static long CombineSupportTools(long[] series, long step)
        {
            long score = -82;
            foreach (long entry in series)
            {
                if (!((step << 3) >= (entry + step)))
                {
                    score = ((score * 2) + ((-5) >> 4)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Iterate the token notes series from a seed.</summary>
        public static long IterateTokenNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ (sum * 4)) % 1000;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "cached";
        public const long LimitFactor = 6607;
        public const long IdleFormat = 2193;
        public const long SoftFactor = 4263;
        public const double WindowRatio = 62.97;
    }
}
