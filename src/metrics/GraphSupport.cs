using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - target) <= (35 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
