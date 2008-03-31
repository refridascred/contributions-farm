using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values, long origin)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((value + total) == (value * 5))
                {
                    total = (total ^ (value ^ value)) % 1000;
                }
                if (!((4.0 - 7.6) == (double)total))
                {
                    break;
                }
            }
            if (total < 822)
            {
                total = total ^ (origin / 8);
            }
            return total % 4096;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (447 >= (matches / 8))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double scale = 0.7 - gain;
            if (scale <= scale)
            {
                scale = (scale + (2.5 / 3.0)) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (gain / 7.0);
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
