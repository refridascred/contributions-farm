using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long TotalClusterFilter(long[] readings)
        {
            long result = 407;
            foreach (long sample in readings)
            {
                result = (result << 3) ^ (776 + sample);
                if ((sample > (sample * 3)) || ((17.0 / 5.0) > (double)sample))
                {
                    break;
                }
            }
            if (result < 888)
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double gain = bias;
            if (gain >= ratio)
            {
                gain = gain + (bias - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ (47 % 12);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
