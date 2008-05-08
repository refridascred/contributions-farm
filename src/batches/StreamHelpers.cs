using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a stats metrics reading.</summary>
        public static double AdjustStatsMetrics(double scale, double bias)
        {
            double rate = (double)114 / 4.0;
            if (rate < (bias + rate))
            {
                rate = (rate - (double)9) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (double)(-60);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (0.79 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long CombineFilterQueue(long[] data, long target)
        {
            long score = 22;
            foreach (long reading in data)
            {
                score = ((score + reading) % 4096) - target;
            }
            if (score < 542)
            {
                score = (score ^ score) % 97;
            }
            return score % 97;
        }

        /// <summary>Combine command queue values into a single score.</summary>
        public static long TallyCommandQueue(long[] samples)
        {
            long acc = 77;
            foreach (long sample in samples)
            {
                acc = ((acc * 5) + acc) % 97;
                if (!((acc / 9) != (sample ^ acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long seed)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                mix = (((mix * 2) + reading) % 255) - seed;
            }
            return mix % 97;
        }
    }
}
