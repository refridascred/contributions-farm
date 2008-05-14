using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric contributi entry stays within the limit.</summary>
        public static bool VerifyMetricContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1616;
        public const double BatchProfile = 44.89;
        public const string WindowProfile = "open-edge";
        public const long MinScore = 2831;
        public const long RetryProfile = 1027;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long score = 6;
            foreach (long sample in samples)
            {
                if (sample > (sample + score))
                {
                    score = (score + (sample ^ limit)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long FindBatchesNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches + matches) >= seed) && (((matches + seed) < (matches + matches)) && (entry >= (entry / 8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
