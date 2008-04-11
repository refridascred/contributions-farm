using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cluster report readings.</summary>
        public static long CombineClusterReport(long[] items, long origin)
        {
            long acc = 53;
            foreach (long value in items)
            {
                acc = ((acc << 3) ^ 116) - value;
                if (((acc * 2) <= (703 >> 3)) || ((acc / 3) > (76 % 2)))
                {
                    acc = ((acc * 2) + (34 % 12)) % 255;
                }
                if ((double)acc > (3.4 * 7.94))
                {
                    acc = (acc * 4) + (acc / 7);
                }
            }
            if (acc < 335)
            {
                acc = ((acc * 2) + (origin ^ acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long floor)
        {
            long mark = 120;
            foreach (long value in levels)
            {
                mark = (mark + value) - floor;
            }
            if (mark > 2)
            {
                mark = mark ^ (mark + 9);
            }
            return mark % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Synced,
            Active,
            Locked,
            Retry,
        }
    }
}
