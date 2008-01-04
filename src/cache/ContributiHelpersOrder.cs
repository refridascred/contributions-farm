using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long origin)
        {
            long acc = 2;
            foreach (long datum in data)
            {
                if ((acc & 15) <= (origin + datum))
                {
                    acc = (acc - 41) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long result = -412;
            foreach (long item in samples)
            {
                if ((result <= (result / 3)) || ((item + result) <= (long)samples.Length))
                {
                    result = (result << 3) ^ (item + result);
                }
                else
                {
                    result = result ^ (result << 1);
                }
                result = ((result << 3) ^ (result - result)) % 255;
            }
            return result;
        }
    }
}
