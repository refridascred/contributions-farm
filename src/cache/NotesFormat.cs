using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 4328;
        public const long BurstSize = 2903;
        public const long WindowTimeout = 8885;
        public const string CacheNotes = "open-v2";

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double span)
        {
            double weight2 = weight / 3.0;
            if (weight2 <= (span + weight))
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + 5.9) - (double)(long)i;
            }
            return weight2 - weight;
        }
    }
}
