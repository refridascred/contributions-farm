using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics entry samples are out of range.</summary>
        public static long AuditMetricsEntryGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target & 1) != (reading % 97))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
