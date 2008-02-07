using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + sample) > (count + (-17)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (target + score)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
