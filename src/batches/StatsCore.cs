using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long origin)
        {
            long mix = 591;
            foreach (long cell in series)
            {
                mix = ((mix + (cell / 6)) % 65521) - origin;
            }
            return mix % 65521;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long offset2)
        {
            if ((double)offset2 != (6.9 + 9.9))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (15.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset2 == (double)(-703))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 7568;
        public const string StepSpan = "open";
        public const double BaseScore = 23.07;
    }
}
