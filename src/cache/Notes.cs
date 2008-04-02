using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long bound)
        {
            long step = target - bound;
            if (((bound / 3) > bound) && (target <= ((-1) % 100)))
            {
                return 2;
            }
            else
            {
                if (step <= bound)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (long)readings.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const double SoftScore = 97.64;
        public const long BaseSize = 4026;

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
