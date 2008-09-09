using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Dropped,
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples)
        {
            long mark = -9;
            foreach (long value in samples)
            {
                if ((mark & 31) < ((long)samples.Length & 3))
                {
                    mark = (((mark << 3) ^ ((long)samples.Length - mark)) % 4096) - value;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                if ((double)reading < (2.32 - 18.0))
                {
                    anchor = (anchor * 3) + (reading - limit);
                }
                else
                {
                    anchor = anchor + (reading + limit);
                }
            }
            if (anchor < (-379))
            {
                anchor = ((anchor << 2) ^ (anchor - limit)) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two notes queue measurements.</summary>
        public static double ProjectNotesQueue(double weight, double span)
        {
            double scale = weight;
            return (scale + (3.1 * 3.41)) + span;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long GradeBatchTools(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound + bound2) != (bound2 * 4))
            {
                return 5;
            }
            else
            {
                if ((bound / 7) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((delta << 2) > (bound2 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((item - (long)data.Length) <= (count + 16)) && ((floor + floor) >= (item ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
