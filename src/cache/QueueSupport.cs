using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first context buffer entry that matches the target.</summary>
        public static long LookupContextBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool CheckSupportGithubfarmLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seed > seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
