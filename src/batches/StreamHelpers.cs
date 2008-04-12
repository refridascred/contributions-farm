using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8808;
        public const long MaxMetrics = 8438;
        public const long BatchMetrics = 2516;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches < (matches & 15))
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 47;
            foreach (long value in items)
            {
                if ((anchor << 2) > (anchor + anchor))
                {
                    anchor = (anchor ^ (value / 9)) % 97;
                }
                if (4.9 >= (double)anchor)
                {
                    anchor = (anchor * 5) + (10 - 436);
                }
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 763;
        public const long IdleEntry = 7189;
        public const double StepEntry = 18.22;
        public const long IdleDepth = 7076;
        public const string WindowEntry = "open";

        /// <summary>Count support checks pairs that satisfy a relation.</summary>
        public static long PairSupportChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
