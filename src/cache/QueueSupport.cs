using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
