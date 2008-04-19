using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 181;
            foreach (long reading in levels)
            {
                if ((9.35 / 3.0) <= (double)reading)
                {
                    carry = (carry + reading) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long TallyQueueCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((-34) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
