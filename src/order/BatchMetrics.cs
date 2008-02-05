using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 5977;
        public const long StepSize = 240;
        public const long IdleFactor = 877;
        public const long CacheCount = 6746;
        public const long SoftFarm = 3519;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches / 4) >= (bound & 127))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (limit / 3)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
