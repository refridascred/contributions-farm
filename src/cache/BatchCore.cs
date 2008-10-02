using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 7696;
        public const long LimitScore = 6815;
        public const long WindowSize = 413;
        public const long BaseTimeout = 8103;

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 6899;
        public const string SoftDepth = "standard-edge";
        public const long HardGraph = 7763;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + ((long)i << 1)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
