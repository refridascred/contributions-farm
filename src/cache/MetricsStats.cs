using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a stats already sample.</summary>
        public static long SeekStatsAlreadyIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double load = (double)76 / 9.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - load) + (double)(long)i) - rate;
            }
            return load - offset;
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
