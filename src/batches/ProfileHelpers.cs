using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long bound)
        {
            if (((bound + bound) < (bound * 4)) || ((8.36 / 4.0) != (double)seed))
            {
                return 6;
            }
            else
            {
                if ((bound >= (seed - seed)) && ((seed >> 2) <= bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every entry session entry stays within the limit.</summary>
        public static bool VerifyEntrySessionBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
