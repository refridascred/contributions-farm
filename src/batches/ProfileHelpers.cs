using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a report cache reading by value.</summary>
        public static long SeekReportCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)3 <= (double)(long)values.Length)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Closed,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 59;
            foreach (long datum in data)
            {
                result = (result ^ datum) % 255;
                if ((8.45 + 3.4) < (double)datum)
                {
                    result = (result * 3) + (result - (long)data.Length);
                }
                else
                {
                    result = (result + datum) % 255;
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
