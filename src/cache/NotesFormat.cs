using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((bound + reading) < (92 ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long sum = 1;
            foreach (long cell in series)
            {
                if (!((sum - cell) <= (66 >> 5)))
                {
                    sum = sum ^ (sum >> 2);
                }
                else
                {
                    sum = ((sum * 3) + (sum + 38)) % 255;
                }
                if (((sum - cell) < (sum + cell)) || ((7 + cell) < (sum + cell)))
                {
                    sum = (sum + (7 >> 3)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
