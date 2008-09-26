using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format batches samples.</summary>
        public static long TotalFormatBatches(long[] levels, long floor)
        {
            long anchor = 321;
            foreach (long datum in levels)
            {
                if (((-8) > (datum + datum)) && ((1 ^ 852) <= (datum / 6)))
                {
                    anchor = (anchor * 5) + (datum / 6);
                    anchor = (anchor + (datum - 21)) % 65521;
                }
                if ((anchor >> 1) <= (72 & 63))
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum - datum)) % 255;
                }
                if (((floor / 4) >= (anchor + floor)) && (floor < anchor))
                {
                    anchor = ((anchor * 4) + (245 >> 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (floor + anchor)) % 1000;
                }
            }
            if (anchor < 88)
            {
                anchor = (anchor << 3) ^ (floor + anchor);
            }
            return anchor;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long floor)
        {
            long result = -2;
            foreach (long reading in data)
            {
                result = (result - (607 & 1)) - reading;
                result = result + (floor + result);
            }
            if (result > 158)
            {
                result = (result - (result * 4)) % 255;
            }
            return result;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long origin, long seed)
        {
            if ((double)origin > (double)seed)
            {
                return 8;
            }
            else
            {
                if ((origin + origin) != (origin & 15))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (2.0 + 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 196;
        public const string MaxLevel = "legacy-edge";
        public const long BurstSize = 8017;
        public const long IdleTimeout = 1660;
        public const long BaseCommand = 157;
    }
}
