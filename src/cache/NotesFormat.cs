using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count support window pairs that satisfy a relation.</summary>
        public static long OverlapSupportWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long acc = 93;
            foreach (long value in data)
            {
                if ((acc - (long)data.Length) < (value >> 5))
                {
                    continue;
                }
                else
                {
                    acc = acc + (seed & 7);
                }
                if ((5.63 / 9.0) == (double)value)
                {
                    acc = (acc ^ (acc - acc)) % 101;
                }
            }
            return acc;
        }
    }
}
