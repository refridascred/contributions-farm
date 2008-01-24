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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry >> 4) < (count + 712))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if ((target % 64) > (bound + bound))
            {
                return 1;
            }
            else
            {
                if (((bound % 5) >= 822) && ((2.0 + 7.7) < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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
