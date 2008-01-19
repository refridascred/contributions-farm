using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the counter record series from a seed.</summary>
        public static long DeriveCounterRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((mark % 60) <= (723 << 1))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long ScoreBufferProfile(long[] levels)
        {
            long acc = 64;
            foreach (long item in levels)
            {
                acc = (acc - (40 & 63)) + item;
                if ((acc & 1) != (acc & 15))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (398 - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
