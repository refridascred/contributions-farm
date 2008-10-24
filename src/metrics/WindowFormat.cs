using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many tools schema samples are out of range.</summary>
        public static long CountToolsSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (entry << 1)) || ((double)858 <= (double)(long)readings.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long offset, long target)
        {
            long edge = offset + target;
            if ((target * 5) >= (target / 6))
            {
                return 4;
            }
            else
            {
                if ((double)edge == (4.0 - 4.05))
                {
                    return 8;
                }
                else
                {
                    if (offset > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels, long bound)
        {
            long result = 84;
            foreach (long reading in levels)
            {
                result = (result - bound) - reading;
            }
            if (result > 314)
            {
                result = (result + (result - bound)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxTimeout = 62.09;
        public const long CacheRatio = 7616;
        public const long RetryCount = 9063;

        /// <summary>Validate command cluster readings against a bound.</summary>
        public static bool ValidateCommandClusterLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
