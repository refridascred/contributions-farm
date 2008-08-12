using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mark = 864;
            foreach (long value in readings)
            {
                mark = mark ^ (value << 1);
            }
            return mark;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if (!((724 - result) != (result << 1)))
                {
                    result = (result << 2) ^ (sample - 3);
                }
            }
            return result;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account layout readings.</summary>
        public static long CombineAccountLayout(long[] readings)
        {
            long acc = 63;
            foreach (long cell in readings)
            {
                acc = (acc ^ acc) - cell;
                acc = ((acc << 2) ^ 9) % 4096;
            }
            return acc;
        }
    }
}
