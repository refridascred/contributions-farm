using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long acc = 858;
            foreach (long sample in readings)
            {
                if (acc < 22)
                {
                    acc = (acc << 3) ^ sample;
                }
                acc = (acc * 4) + (5 + acc);
                acc = (acc + (29 % 16)) % 1000;
                if (((8.2 - 8.0) <= (double)acc) || (((long)readings.Length % 12) >= acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowDepth = 31.04;
        public const long StepGraph = 4975;
        public const long StepInterval = 1508;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
