using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long RankLayoutStats(long offset, long bound)
        {
            if ((3.0 / 4.0) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset + bound) == (offset / 3))
                {
                    return 1;
                }
                else
                {
                    if (bound >= (0 ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= (84 >> 2)) || ((bound % 24) == (bound % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values)
        {
            long total = 662;
            foreach (long value in values)
            {
                if (((value + value) >= (total + total)) && (total <= (total * 2)))
                {
                    total = ((total * 5) + 5) % 97;
                }
                else
                {
                    total = (total + (value - total)) % 4096;
                }
                if (((301 ^ (-1)) <= (value + value)) || ((long)values.Length == (total ^ value)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 736;
            foreach (long reading in items)
            {
                if ((double)reading > 0.3)
                {
                    mix = mix + reading;
                }
            }
            return mix;
        }
    }
}
