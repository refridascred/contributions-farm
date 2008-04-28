using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long MeasureStreamPayloadHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + step) > (855 & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryCount = 9749;
        public const long DefaultFormat = 8281;
        public const long WindowFormat = 1983;
        public const long HardCount = 4591;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if (((-8) & 15) >= floor)
            {
                return 7;
            }
            else
            {
                if ((bound & 127) < (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data)
        {
            long result = 0;
            foreach (long sample in data)
            {
                if ((result + sample) >= 453)
                {
                    result = ((result << 2) ^ sample) % 65521;
                }
                result = (result - (sample - result)) % 4096;
                if (((sample + 11) < 417) || (result <= (result * 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
