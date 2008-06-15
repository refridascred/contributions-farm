using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 2714;
        public const long BatchRatio = 4888;
        public const double IdleLevel = 38.28;
        public const double BurstContributi = 58.67;
        public const long MinContributi = 7096;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer account value from a seed.</summary>
        public static long SeriesBufferAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset ^ offset) != (133 >> 5))
                {
                    score = (score - (score / 5)) % 65521;
                    score = (score + (82 + 323)) % 101;
                }
                if (!(((3.0 + 2.5) > (double)score) && ((offset / 9) != ((-96) % 97))))
                {
                    score = score ^ (offset & 1);
                    score = score - offset;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
