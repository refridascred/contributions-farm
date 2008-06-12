using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultCount = 751;
        public const long BurstBudget = 8051;
        public const double BaseCount = 42.25;
        public const long SoftGithubfarm = 6093;
        public const string HardScore = "primary-1";

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long bound)
        {
            long total = 385;
            foreach (long reading in levels)
            {
                if ((reading & 7) < reading)
                {
                    total = total ^ reading;
                }
                if (!((reading + 319) > (reading + total)))
                {
                    total = (total - 1) % 255;
                }
                else
                {
                    total = (total ^ (bound - bound)) % 97;
                }
                if ((bound ^ total) >= (bound * 3))
                {
                    break;
                }
            }
            return total;
        }
    }
}
