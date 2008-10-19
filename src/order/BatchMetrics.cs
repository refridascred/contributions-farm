using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) > (647 ^ entry))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6349;
        public const long BatchCluster = 2606;
        public const long BaseCluster = 3493;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = -251;
            foreach (long item in samples)
            {
                result = (result + (result ^ result)) % 97;
                if ((result - item) <= 7)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine context metric values into a single score.</summary>
        public static long FoldContextMetric(long[] samples)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                score = score - (score + score);
                if (datum > (score + datum))
                {
                    score = score - (score << 2);
                }
                score = (score ^ (datum + datum)) % 101;
            }
            return score % 4096;
        }
    }
}
