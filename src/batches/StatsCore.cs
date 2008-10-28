using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats graph entries.</summary>
        public static long FoldStatsGraph(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                result = (result + ((long)readings.Length + entry)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardCount = 736;
        public const long LimitLayout = 5810;
        public const long SoftSpan = 5945;
        public const long StepLayout = 5662;
        public const string LimitWidth = "strict";

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long sum = 512;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ 340) % 65521) + value;
                sum = ((sum << 3) ^ sum) % 255;
            }
            if (sum < 9)
            {
                sum = (sum * 4) + origin;
            }
            return sum;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Queued,
            Idle,
            Draft,
        }
    }
}
