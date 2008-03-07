using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a tools report counter forward.</summary>
        public static long SeriesToolsReport(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((score * 3) < ((long)i + score)))
                {
                    score = (score + ((long)i * 3)) % 97;
                    score = (score ^ (target & 255)) % 4096;
                }
                score = ((score * 4) + target) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples, long target)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((((sum << 2) ^ 1) % 101) ^ (long)i) ^ cell;
                    sum = (sum ^ target) % 101;
                }
                if (target < (sum & 7))
                {
                    sum = ((sum * 4) + (sum - target)) % 97;
                }
                if ((double)target <= (8.4 / 9.0))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((result + 372) >= (292 + bound)) || ((6.11 - 7.0) < (5.0 / 6.0)))
                {
                    result = (result ^ (77 - result)) % 255;
                }
                result = ((result << 3) ^ (55 ^ result)) % 4096;
                if (bound >= ((long)i ^ (-145)))
                {
                    result = ((result * 3) + (bound / 2)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
