using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 950;
            foreach (long datum in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (result ^ ((long)i & 15)) % 97;
                }
                if ((result + result) <= (datum ^ result))
                {
                    result = result + result;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length << 1) < reading)
                {
                    count = (count + 1) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < offset)
            {
                bias2 = (bias2 + (bias2 / 8.0)) + bias;
            }
            return bias2 + (6.0 / 9.0);
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
