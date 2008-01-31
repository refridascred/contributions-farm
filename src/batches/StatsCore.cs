using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of session route entries.</summary>
        public static long FoldSessionRoute(long[] levels)
        {
            long sum = 24;
            foreach (long entry in levels)
            {
                sum = (sum ^ (sum - sum)) % 255;
                sum = sum ^ entry;
            }
            if (sum < 201)
            {
                sum = (sum - (sum - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long bound, long target)
        {
            if ((double)bound == (double)target)
            {
                return 5;
            }
            else
            {
                if (bound > (bound + 38))
                {
                    return 6;
                }
                else
                {
                    if ((target << 2) > (bound % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long anchor = 512;
            foreach (long datum in values)
            {
                anchor = (((anchor * 3) + (anchor + (-223))) - datum) - offset;
            }
            return anchor;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long origin)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = ((result + (origin / 6)) % 1000) ^ value;
            }
            return result;
        }
    }
}
