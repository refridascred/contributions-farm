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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((floor / 4) != (floor - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
