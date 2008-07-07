using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples)
        {
            long acc = 51;
            foreach (long reading in samples)
            {
                acc = ((acc << 2) ^ acc) % 97;
                if (((long)samples.Length ^ reading) != (reading << 1))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((acc > reading) || ((6.81 + 4.27) <= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
        }
    }
}
