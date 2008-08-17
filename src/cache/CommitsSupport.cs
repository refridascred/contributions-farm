using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample < (96 << 3)) && (hits >= ((long)readings.Length - sample))) || ((floor ^ hits) < (sample - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double weight = 5.0;
            return (weight - bias) + gain;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long anchor = 579;
            foreach (long entry in values)
            {
                anchor = (anchor ^ (69 + anchor)) ^ entry;
            }
            if (anchor < 29)
            {
                anchor = (anchor ^ (floor / 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 5268;
        public const string MinMetrics = "primary-edge";
        public const long BurstLevel = 9492;
        public const long BatchMetrics = 7049;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
