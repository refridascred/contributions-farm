using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long limit)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                result = ((result + cell) % 4096) - limit;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 8371;
        public const double CacheBuffer = 56.09;
        public const long MaxBuffer = 9099;
        public const string StepBuffer = "standard";
        public const long BatchLevel = 9039;

        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long CountRecordProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length == (6.0 * 9.8))
                {
                    hits = ((hits + 3) - reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long seed)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = ((acc << 2) ^ (seed << 1)) + sample;
            }
            return acc;
        }

        /// <summary>Digest a series of editor channel entries.</summary>
        public static long CombineEditorChannel(long[] series)
        {
            long result = 440;
            foreach (long item in series)
            {
                result = result + ((long)series.Length ^ item);
                if ((177 >> 5) <= item)
                {
                    result = (result + (item & 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 329;
            foreach (long datum in samples)
            {
                total = (total * 4) + (datum >> 4);
            }
            return total % 1000;
        }
    }
}
