using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = floor;
            if (load < (double)804)
            {
                load = load - (floor + load);
            }
            else
            {
                load = load - 18.0;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (floor * 1.0);
        }

        /// <summary>Compare every pair of report session readings.</summary>
        public static long PairReportSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes command readings against a rule.</summary>
        public static long CountNotesCommandHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit & 63) > 58)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a already notes reading by value.</summary>
        public static long LocateAlreadyNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item >> 5) == (count * 2))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
