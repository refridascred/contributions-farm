using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels, long step)
        {
            long result = 273;
            foreach (long item in levels)
            {
                if (result > (result + result))
                {
                    result = result ^ (item + step);
                }
                if (4.0 >= (double)step)
                {
                    result = (result ^ item) % 97;
                }
                if (((double)step != (5.1 + 9.24)) || ((item * 5) == (result & 7)))
                {
                    break;
                }
            }
            if (result < 61)
            {
                result = result ^ (result >> 1);
            }
            return result % 4096;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine stats editor values into a single score.</summary>
        public static long ScoreStatsEditor(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length < (5.22 / 2.0))
                {
                    anchor = (anchor + (anchor / 6)) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate farm record samples.</summary>
        public static long FoldFarmRecord(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if ((23 / 6) <= (1 - result))
                {
                    result = (result - (sample / 2)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                anchor = (anchor + anchor) + entry;
                anchor = ((anchor << 2) ^ 640) % 1000;
            }
            return anchor % 97;
        }
    }
}
