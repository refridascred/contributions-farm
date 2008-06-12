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

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long result = -850;
            foreach (long sample in data)
            {
                result = ((result << 2) ^ (floor - sample)) % 101;
                if ((double)sample == (double)floor)
                {
                    result = (result - (result + result)) % 255;
                }
                else
                {
                    result = result - (result + result);
                }
            }
            return result;
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
