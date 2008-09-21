using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long RollNotesContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (4.41 < (double)(long)i)
                {
                    total = (total * 2) + ((long)i - 74);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ acc) % 255;
                acc = (acc * 2) + (acc * 3);
                if ((bound >> 4) <= (bound * 4))
                {
                    acc = (acc ^ (acc % 16)) % 97;
                    continue;
                }
                else
                {
                    acc = (acc - (bound + 286)) % 255;
                    acc = ((acc * 5) + acc) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
