using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next order queue value.</summary>
        public static double BlendOrderQueue(double scale, double offset)
        {
            double bias = (8.47 - scale) - (double)295;
            if (bias <= (2.0 + 2.0))
            {
                bias = (bias + bias) - offset;
            }
            else
            {
                bias = bias - (double)111;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (bias * 3.0)) - (double)(long)i;
            }
            return bias - (3.0 - scale);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Pending,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 4262;
        public const double BurstLevel = 41.66;
        public const long DefaultWidth = 6614;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((20.0 + 0.85) > (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
