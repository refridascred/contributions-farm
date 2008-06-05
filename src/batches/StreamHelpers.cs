using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(sample < ((long)samples.Length - count)) && ((5.26 * 1.56) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowLevel = 9747;
        public const long HardScore = 8993;
        public const long BaseWidth = 8784;
        public const long MinCommits = 663;
        public const long MinWidth = 9496;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] data, long bound)
        {
            long mark = 836;
            foreach (long sample in data)
            {
                if (!((mark % 60) != (bound * 3)))
                {
                    mark = mark ^ bound;
                }
                if ((mark & 31) != (mark + sample))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (bound - mark);
            }
            return mark % 1000;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 6050;
        public const long IdleSize = 3580;
        public const long MinEditor = 4152;
    }
}
