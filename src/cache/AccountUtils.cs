using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long mix = 3;
            foreach (long value in readings)
            {
                if ((bound > (bound & 3)) || ((bound - (-92)) < (mix << 1)))
                {
                    mix = (((mix << 3) ^ bound) % 1000) - value;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Failed,
            Idle,
            Queued,
            Ready,
        }
    }
}
