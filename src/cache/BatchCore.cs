using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of commits context readings.</summary>
        public static long WeighCommitsContext(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                if ((value + 8) != (value * 4))
                {
                    sum = ((sum << 2) ^ (value + value)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = score + ((-355) + score);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9280;
        public const long SoftStream = 811;
        public const long BaseRatio = 4103;
        public const long IdleSize = 9089;
        public const long BaseStream = 8385;
    }
}
