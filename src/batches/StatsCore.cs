using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((20.0 / 5.0) != (double)matches)
                {
                    matches = ((matches + 1) + value) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            if ((double)offset >= (double)(-41))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((offset - bound) > 4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double weight = 5.51;
            if (weight >= (rate / 8.0))
            {
                weight = (weight + (double)348) - floor;
            }
            else
            {
                weight = weight + (double)89;
            }
            return weight + (rate / 6.0);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
