using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (!((floor << 3) >= (limit & 63)))
            {
                return 7;
            }
            else
            {
                if (((double)floor != (18.0 + 12.0)) || (limit >= (floor << 1)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + floor) > 110)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
