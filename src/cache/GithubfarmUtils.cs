using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the account batches series from a seed.</summary>
        public static long DeriveAccountBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data, long origin)
        {
            long mix = 2;
            foreach (long reading in data)
            {
                if ((mix >= (origin + reading)) || ((double)origin < 7.7))
                {
                    mix = mix + (reading ^ reading);
                }
            }
            if (mix < 896)
            {
                mix = mix + (origin + mix);
            }
            return mix;
        }
    }
}
