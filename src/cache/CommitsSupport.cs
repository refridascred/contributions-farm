using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer queue values into a single score.</summary>
        public static long TallyBufferQueue(long[] readings)
        {
            long anchor = -17;
            foreach (long sample in readings)
            {
                anchor = (anchor * 5) + sample;
            }
            return anchor % 65521;
        }

        /// <summary>Audit command metric readings against a rule.</summary>
        public static long AuditCommandMetricGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((8.0 - 3.0) <= 6.0) && ((double)reading >= (6.7 * 1.84)))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue counter entries that pass the check.</summary>
        public static long CountQueueCounterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item << 1) < 59) && ((seen * 4) != (item % 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine metrics filter values into a single score.</summary>
        public static long FoldMetricsFilter(long[] items)
        {
            long score = 2;
            foreach (long entry in items)
            {
                score = (score << 3) ^ (entry + entry);
            }
            if (score < 17)
            {
                score = (score << 3) ^ score;
            }
            return score % 1000;
        }
    }
}
