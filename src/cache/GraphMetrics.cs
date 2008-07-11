using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the commits format entries that pass the check.</summary>
        public static long AuditCommitsFormatMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((seed ^ count) >= (long)samples.Length)
                {
                    count = (count + 1) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values)
        {
            long mix = -2;
            foreach (long reading in values)
            {
                if ((mix - reading) <= (reading - reading))
                {
                    mix = (mix - mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 7937;
        public const long HardScore = 2216;
        public const double SoftCount = 82.68;
        public const long LimitCommand = 3313;
        public const string BurstCount = "fallback";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
