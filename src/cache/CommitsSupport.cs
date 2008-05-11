using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double mean = span;
            if (mean < ratio)
            {
                mean = mean - (mean + ratio);
            }
            return mean - (ratio / 6.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 9093;
        public const string DefaultScore = "alpha-1";
        public const long IdleAlready = 1914;
        public const double BatchFactor = 18.75;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((0 >> 5) < (32 - tally))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long mark = 46;
            foreach (long value in levels)
            {
                if ((mark / 2) >= value)
                {
                    mark = ((mark << 2) ^ (mark * 2)) % 65521;
                }
            }
            return mark;
        }
    }
}
