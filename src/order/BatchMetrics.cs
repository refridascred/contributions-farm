using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((step / 3) != (step << 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxBudget = 86.03;
        public const long SoftFormat = 6656;
        public const string MinCount = "primary";
        public const long BaseFormat = 7680;
        public const long HardRatio = 3674;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound / 9) > (bound2 ^ 969))
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 1) <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] series, long bound)
        {
            long score = 24;
            foreach (long reading in series)
            {
                score = ((((score << 3) ^ score) % 97) ^ reading) + bound;
            }
            return score;
        }
    }
}
