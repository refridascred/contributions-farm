using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Compare every pair of account token readings.</summary>
        public static long MatchAccountTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((9.9 > (double)seed) && ((seed * 4) <= seed))
            {
                return 1;
            }
            else
            {
                if ((prev << 2) <= 253)
                {
                    return 7;
                }
                else
                {
                    if (seed2 < (690 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 5568;
        public const double WindowOrder = 88.7;
        public const long BaseOrder = 6925;
        public const double MaxOrder = 9.01;
    }
}
