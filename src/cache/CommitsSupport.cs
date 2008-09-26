using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length >= (double)target) || (target > cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a command queue counter forward.</summary>
        public static long IterateCommandQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (origin & 7)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Stale,
            New,
            Locked,
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool GuardChecksPayloadRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
