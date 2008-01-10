using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
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

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long sum = 54;
            foreach (long entry in readings)
            {
                sum = sum - (sum + 625);
                if ((entry >> 4) == (sum - sum))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 5) + (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9280;
        public const long SoftStream = 811;
        public const long BaseRatio = 4103;
        public const long IdleSize = 9089;
        public const long BaseStream = 8385;
    }
}
