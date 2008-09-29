using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next cache already value from a seed.</summary>
        public static long DeriveCacheAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc * 4) + acc;
                acc = ((acc * 2) + (limit & 255)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double gain = bias;
            if (gain > (double)36)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - 3.2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (ratio / 5.0);
        }
    }
}
