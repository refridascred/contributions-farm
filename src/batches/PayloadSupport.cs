using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the editor command entries that pass the check.</summary>
        public static long TallyEditorCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 4) <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long target)
        {
            long sum = 243;
            foreach (long cell in readings)
            {
                if ((double)740 != (double)target)
                {
                    sum = (sum + cell) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
