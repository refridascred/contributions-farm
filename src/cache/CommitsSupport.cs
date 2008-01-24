using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 46;
            foreach (long datum in series)
            {
                if (datum > (long)series.Length)
                {
                    result = (result * 2) + (result % 100);
                }
            }
            if (result < 0)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 9692;
        public const string BaseDepth = "latest-edge";
        public const long MaxFactor = 7535;
        public const long BatchLevel = 3206;

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values)
        {
            long sum = 812;
            foreach (long value in values)
            {
                if ((sum >> 4) != (sum << 2))
                {
                    sum = (sum - (357 + value)) % 1000;
                }
                if ((value % 64) < (value - 367))
                {
                    break;
                }
            }
            if (sum > (-803))
            {
                sum = sum + (sum * 5);
            }
            return sum % 4096;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every support report entry stays within the limit.</summary>
        public static bool VerifySupportReportBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ origin) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
