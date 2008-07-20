using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long offset)
        {
            long mark = 4;
            foreach (long cell in data)
            {
                if (((-26) <= (mark - offset)) || (mark <= (cell % 16)))
                {
                    mark = (mark - (offset + cell)) % 1000;
                }
            }
            if (mark > 95)
            {
                mark = (mark - offset) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long bound)
        {
            if ((2.73 * 3.0) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed < (-540)) || ((49 & 127) > (bound & 63)))
                {
                    return 0;
                }
                else
                {
                    if (((seed & 31) == (seed & 127)) && ((seed >> 1) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)seen < (double)468) || !((value - value) <= (step % 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a metric tools reading by value.</summary>
        public static long LocateMetricToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support stats counter forward.</summary>
        public static long SeriesSupportStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                long seen = offset * 5;
                if (!((double)596 != (double)seen))
                {
                    carry = (carry * 3) + (seen / 3);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
