using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long ScoreFarmNotes(long[] readings)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                if ((item - mark) > mark)
                {
                    mark = (mark - mark) % 4096;
                }
                mark = ((mark * 3) + item) % 255;
                if (!((mark % 8) < 514))
                {
                    mark = (mark * 3) + item;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Derive the next support metric value from a seed.</summary>
        public static long RollSupportMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 3) ^ (limit + acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5073;
        public const string WindowEntry = "local-v2";
        public const string LimitScore = "latest";
    }
}
