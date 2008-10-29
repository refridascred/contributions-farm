using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (anchor * 3)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of cluster githubfarm readings.</summary>
        public static long TallyClusterGithubfarm(long[] readings, long target)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                result = ((result ^ (reading * 4)) % 1000) - target;
            }
            return result;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long target)
        {
            long cur = limit - target;
            if ((limit ^ target) <= (cur * 5))
            {
                return 4;
            }
            else
            {
                if ((cur >> 5) != (8 + limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next tools order value from a seed.</summary>
        public static long RollToolsOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
