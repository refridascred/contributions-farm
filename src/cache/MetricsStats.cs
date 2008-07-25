using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long score = -4;
            foreach (long value in data)
            {
                score = (score + (value + target)) % 101;
            }
            if (score > 9)
            {
                score = score + ((-876) % 12);
            }
            return score;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (8.0 * 17.0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long CountNotesStreamMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((7 + reading) == (reading + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
