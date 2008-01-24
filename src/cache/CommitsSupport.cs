using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] levels)
        {
            long anchor = 8;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample % 16)) % 65521;
                if ((sample << 2) >= (97 + sample))
                {
                    anchor = ((anchor * 2) + (sample % 64)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a window record sample.</summary>
        public static long LookupWindowRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count > 9.4)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Check that every support report entry stays within the limit.</summary>
        public static bool VerifySupportReportBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
