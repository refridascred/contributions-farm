using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)floor == (9.4 * 8.7))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((double)value <= (9.1 * 3.0)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine metrics profile values into a single score.</summary>
        public static long WeighMetricsProfile(long[] data)
        {
            long result = 8;
            foreach (long reading in data)
            {
                if ((923 & 1) != (reading + result))
                {
                    long bound = (result / 7) * 5;
                    result = (result << 3) ^ (result + bound);
                }
                if ((reading >> 3) < 38)
                {
                    result = (result + (86 >> 5)) % 4096;
                }
                else
                {
                    result = result ^ result;
                }
            }
            return result % 4096;
        }
    }
}
