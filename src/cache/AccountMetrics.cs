using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Match up report cache samples.</summary>
        public static long OverlapReportCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank filter githubfarm input into a small class.</summary>
        public static long ClassifyFilterGithubfarm(long offset, long floor)
        {
            long next = offset ^ floor;
            if (offset < (floor & 255))
            {
                return 4;
            }
            else
            {
                if (272 <= (next + offset))
                {
                    return 7;
                }
                else
                {
                    if (21 <= (next - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((next % 2) <= floor) && (6.7 > (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long WeighEntryContext(long[] samples, long origin)
        {
            long acc = 957;
            foreach (long reading in samples)
            {
                if ((double)reading > 11.0)
                {
                    acc = (acc + (origin / 9)) % 101;
                }
                else
                {
                    acc = (acc ^ (reading * 2)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
