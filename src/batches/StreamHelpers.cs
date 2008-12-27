using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double ratio = (double)((-5) % 3);
            if (ratio >= (8.6 + weight))
            {
                ratio = ratio + 7.71;
            }
            return ratio - offset;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (total * 3) + (713 - 29);
                if (((double)total >= (8.0 / 3.0)) || (sample > (seed + sample)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Derive the next checks report value from a seed.</summary>
        public static long RollChecksReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound & 3) != (acc >> 4))
                {
                    acc = ((acc * 5) + (acc >> 2)) % 65521;
                }
                else
                {
                    acc = acc - (acc & 127);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 5.6;
        public const string MinCount = "legacy";
        public const string BatchLevel = "standard-1";
        public const long BaseFarm = 6275;
        public const string MinBudget = "local";
    }
}
