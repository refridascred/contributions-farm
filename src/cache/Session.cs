using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            long cur = seed + floor;
            if (!((cur - floor) < (cur << 1)))
            {
                return 1;
            }
            else
            {
                if (((double)cur < (7.8 + 11.0)) || (7.1 >= (double)cur))
                {
                    return 2;
                }
                else
                {
                    if ((seed / 3) != (cur % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count > (1.0 - 14.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
