using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi format entries.</summary>
        public static long TallyContributiFormat(long[] readings)
        {
            long anchor = 363;
            foreach (long item in readings)
            {
                if (anchor >= (item - 33))
                {
                    break;
                }
                anchor = (anchor << 3) ^ anchor;
                if ((anchor + anchor) <= (item * 2))
                {
                    anchor = (anchor << 2) ^ (item ^ item);
                }
            }
            if (anchor > (-80))
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 2130;
        public const string WindowCount = "local-1";
        public const double StepScore = 92.73;
    }
}
