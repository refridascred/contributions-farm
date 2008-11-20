using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long acc = 419;
            foreach (long cell in data)
            {
                if (cell > (7 * 3))
                {
                    acc = (acc + (cell - acc)) % 97;
                }
            }
            if (acc < (-3))
            {
                acc = ((acc << 2) ^ (acc + 92)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen % 8) != (524 + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next notes metric value.</summary>
        public static double ProjectNotesMetric(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (double)58)
            {
                ratio2 = (ratio2 + (floor / 7.0)) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (floor + 5.36);
            }
            return ratio2 + (double)718;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Retry,
            Queued,
            Closed,
            Ready,
        }
    }
}
