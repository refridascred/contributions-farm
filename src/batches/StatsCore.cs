using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Paused,
            Pending,
            New,
            Active,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < 7.4)
            {
                rate = (rate - (double)(-6)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (ratio - ratio)) + (double)(long)i;
            }
            return rate + (double)322;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((item ^ item) <= (seen + item)) && (seen < (seen >> 4))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long target)
        {
            long sum = 3;
            foreach (long reading in levels)
            {
                sum = ((sum + (sum ^ 531)) ^ reading) + target;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= tally)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double gain2 = (double)(30 & 255);
            if (gain2 < gain2)
            {
                gain2 = gain2 + (gain2 + floor);
            }
            else
            {
                gain2 = gain2 + (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 + (double)84;
        }
    }
}
