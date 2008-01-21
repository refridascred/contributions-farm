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

        /// <summary>Audit profile token readings against a rule.</summary>
        public static long CountProfileTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + 6) != (value + value)) || (((long)samples.Length - matches) >= (value & 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
