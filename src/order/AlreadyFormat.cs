using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((5.0 / 4.0) > (double)hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ ((long)i << 3)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9297;
        public const long BatchReport = 3361;
        public const long RetryReport = 5879;

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double weight = (6.73 * 14.0) + (double)39;
            if (weight >= (double)535)
            {
                weight = weight - (offset / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (gain / 3.0)) - (double)(long)i;
            }
            return weight + (gain * 4.5);
        }
    }
}
