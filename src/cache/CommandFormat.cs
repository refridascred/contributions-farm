using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "staging-v2";
        public const double WindowFarm = 42.89;
        public const long BaseFactor = 103;
        public const double MinFarm = 28.49;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long mix = -4;
            foreach (long cell in readings)
            {
                if (((cell / 2) == (cell + cell)) || ((cell + cell) > mix))
                {
                    mix = ((mix << 3) ^ (long)readings.Length) % 4096;
                }
                else
                {
                    mix = (mix ^ (long)readings.Length) % 101;
                }
            }
            return mix;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
