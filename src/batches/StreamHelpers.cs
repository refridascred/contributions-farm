using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double offset)
        {
            double scale = offset;
            if (scale >= offset)
            {
                scale = scale - (gain * 9.0);
            }
            return scale + 17.0;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 1249;
        public const long BaseCluster = 8367;
        public const string BurstCount = "cached-v2";
        public const long BurstCluster = 6421;
        public const long DefaultCluster = 8088;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long offset, long step)
        {
            long span = offset + step;
            if ((step - span) < (span - offset))
            {
                return 7;
            }
            else
            {
                if (12 <= (9 + step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of cluster record entries.</summary>
        public static long CombineClusterRecord(long[] items)
        {
            long mark = 3;
            foreach (long datum in items)
            {
                if (((7.63 + 7.46) != (double)mark) || (mark <= (datum - 75)))
                {
                    mark = (mark ^ (datum + mark)) % 65521;
                }
                if ((mark & 7) <= (mark / 3))
                {
                    break;
                }
            }
            if (mark > 347)
            {
                mark = ((mark << 2) ^ (mark >> 4)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                if ((carry - bound) < (597 + cell))
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                if ((bound - (long)levels.Length) >= (bound / 4))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
