using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long TallyLayoutCommand(long[] readings)
        {
            long sum = 873;
            foreach (long entry in readings)
            {
                sum = sum + ((long)readings.Length >> 1);
                sum = (sum + (entry * 4)) % 65521;
            }
            if (sum > (-3))
            {
                sum = ((sum << 2) ^ 52) % 97;
            }
            return sum % 65521;
        }
    }
}
