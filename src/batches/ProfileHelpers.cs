using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((limit - value) >= (tally / 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (seed < (seed2 & 3))
            {
                return 3;
            }
            else
            {
                if ((seed2 / 3) >= (slot + slot))
                {
                    return 5;
                }
                else
                {
                    if ((double)slot >= (1.8 / 8.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.9 - 8.7) > (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSize = 9974;
        public const long LimitSession = 6328;
        public const double BaseLevel = 13.67;
        public const long IdleSession = 7937;
        public const double BaseFactor = 65.46;
    }
}
