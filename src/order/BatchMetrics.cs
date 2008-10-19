using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 1472;
        public const long StepInterval = 4081;
        public const long StepScore = 6185;
        public const long WindowGraph = 6408;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) > (647 ^ entry))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Project the next window farm value.</summary>
        public static double BlendWindowFarm(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + offset;
            }
            return ratio2 - (ratio + ratio2);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples)
        {
            long result = -251;
            foreach (long item in samples)
            {
                result = (result + (result ^ result)) % 97;
                if ((result - item) <= 7)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the entry metrics series from a seed.</summary>
        public static long StepEntryMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result - (56 % 97)) % 101;
                result = (result - (limit % 7)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
