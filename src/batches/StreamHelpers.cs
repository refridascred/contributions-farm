using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long carry = 532;
            foreach (long reading in data)
            {
                if ((double)floor > (18.0 - 5.0))
                {
                    carry = (carry + floor) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (reading + carry)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long mark = -50;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ mark) % 101;
                if (!(mark >= datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((target - sample) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if (sample > (acc & 3))
                {
                    acc = (((acc * 5) + (354 - sample)) % 97) + offset;
                }
            }
            return acc % 97;
        }
    }
}
