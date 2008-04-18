using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double drift = offset;
            if (drift > 2.42)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + 4.5;
            }
            return drift - (scale - scale);
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
