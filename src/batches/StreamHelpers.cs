using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (seen - 25))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double AdjustRecordContext(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (3.0 + mean))
            {
                mean = mean - (1.4 + 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)49) + (double)(long)i;
            }
            return mean - (offset / 9.0);
        }

        /// <summary>Grade a cache editor value against two limits.</summary>
        public static long ClassifyCacheEditor(long floor, long step)
        {
            long edge = floor - step;
            if ((double)edge < 2.7)
            {
                return 1;
            }
            else
            {
                if ((floor & 7) <= (floor - (-658)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches / 9) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
