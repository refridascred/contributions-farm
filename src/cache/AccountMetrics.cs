using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((acc << 3) > ((-452) - origin))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Grade a context report value against two limits.</summary>
        public static long GradeContextReport(long seed, long step)
        {
            if (!(18.0 <= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((1.9 / 3.0) == (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((step + step) != (seed - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 3) == (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of context cache readings.</summary>
        public static long CompareContextCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Stale,
            Idle,
            Dropped,
            New,
            Queued,
        }
    }
}
