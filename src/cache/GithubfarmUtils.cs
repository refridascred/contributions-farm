using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data)
        {
            long result = 24;
            foreach (long entry in data)
            {
                result = (result + (5 + entry)) % 255;
                result = (result * 5) + (result - 6);
                if ((double)result <= 3.7)
                {
                    result = (result + (result + entry)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long sum = 50;
            foreach (long item in readings)
            {
                sum = (sum ^ ((long)readings.Length + sum)) % 1000;
                if (((3.0 + 8.0) < (double)sum) && ((sum * 2) < (sum % 16)))
                {
                    sum = (sum * 4) + item;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum / 4)) % 97;
                }
            }
            if (sum < 107)
            {
                sum = ((sum * 4) + 46) % 101;
            }
            return sum % 65521;
        }
    }
}
