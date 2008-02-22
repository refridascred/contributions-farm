using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter githubfarm entry that matches the target.</summary>
        public static long LocateFilterGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings, long limit)
        {
            long anchor = 274;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 2) ^ (cell % 3)) % 65521;
            }
            if (anchor < 951)
            {
                anchor = anchor - (limit + 180);
            }
            return anchor;
        }
    }
}
