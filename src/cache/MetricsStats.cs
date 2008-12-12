using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long step)
        {
            long sum = 6;
            foreach (long cell in series)
            {
                if (((cell % 8) >= (cell & 3)) || ((double)cell >= (8.22 / 4.0)))
                {
                    sum = (((sum * 4) + sum) % 101) + step;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + hits) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Idle,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ ((-8) ^ offset)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
