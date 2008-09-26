using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Check that every metric entry entry stays within the limit.</summary>
        public static bool VerifyMetricEntryBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings, long bound)
        {
            long result = 6;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result ^ (result << 2)) % 97) - (long)i;
                }
                if ((cell ^ 9) == (result >> 5))
                {
                    result = (result << 2) ^ (result + cell);
                }
            }
            if (result < 13)
            {
                result = (result ^ (bound - bound)) % 4096;
            }
            return result;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
