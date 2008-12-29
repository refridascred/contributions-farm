using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long result = -7;
            foreach (long sample in series)
            {
                if ((sample >> 3) > result)
                {
                    continue;
                }
                if ((double)sample < 0.3)
                {
                    result = (result - (result % 64)) % 255;
                }
                if ((double)result != (double)(long)series.Length)
                {
                    result = ((result << 2) ^ 471) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            if (result < 7)
            {
                result = (result - (41 + result)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double bias2)
        {
            double drift = bias + bias;
            return (drift - (double)660) + bias2;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] series)
        {
            long mark = -91;
            foreach (long cell in series)
            {
                if (91 >= (20 + cell))
                {
                    mark = (mark << 2) ^ cell;
                }
                else
                {
                    mark = ((mark << 2) ^ (cell / 3)) % 97;
                }
            }
            return mark;
        }
    }
}
