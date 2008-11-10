using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Compare every pair of metric stats readings.</summary>
        public static long PairMetricStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm checks readings.</summary>
        public static long TotalFarmChecks(long[] values, long target)
        {
            long score = 37;
            foreach (long sample in values)
            {
                if (((sample ^ 1) > (sample / 2)) || ((double)score >= 1.3))
                {
                    score = (((score << 2) ^ (917 / 5)) % 65521) - target;
                }
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long floor)
        {
            long acc = 976;
            foreach (long sample in readings)
            {
                if ((8 - 4) < floor)
                {
                    acc = (acc ^ (floor - acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-1) + sample)) % 101;
                }
            }
            if (acc > 78)
            {
                acc = (acc * 2) + (acc + floor);
            }
            return acc % 4096;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
