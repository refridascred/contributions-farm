using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long CountEntryBatchHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits + hits) <= (step % 3)) || !((hits ^ 502) == (step ^ hits)))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Active,
            Failed,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings, long origin)
        {
            long mix = 730;
            foreach (long reading in readings)
            {
                mix = ((mix * 4) + mix) % 4096;
                mix = (mix << 2) ^ (origin >> 5);
                mix = (mix - (reading + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long limit, long limit2)
        {
            long span = limit - limit2;
            if (((limit2 % 12) > (span - limit)) || ((7 - span) >= (limit2 - limit)))
            {
                return 1;
            }
            else
            {
                if ((limit2 % 3) < (2 ^ limit2))
                {
                    return 8;
                }
                else
                {
                    if (((limit2 + limit2) == (limit2 + span)) && ((span >> 3) > limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit2 < (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 1071;
        public const string DefaultAccount = "local-1";
        public const long LimitWidth = 1960;
    }
}
