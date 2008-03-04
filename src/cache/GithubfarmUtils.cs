using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Locked,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Locate a stream token reading by value.</summary>
        public static long SeekStreamTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile commits readings against a bound.</summary>
        public static bool CheckProfileCommitsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((limit ^ seen) >= (seen + (long)data.Length)) || ((limit & 63) == ((long)data.Length * 4)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
