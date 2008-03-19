using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long target)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                if ((18 + reading) != (state << 3))
                {
                    state = (state - (13 * 2)) % 1000;
                    state = (state ^ (target % 24)) % 101;
                }
                if ((reading << 2) >= (reading + reading))
                {
                    state = (state * 3) + (reading ^ state);
                }
                else
                {
                    state = (state - (state + reading)) % 101;
                }
            }
            if (state > 726)
            {
                state = (state ^ (state - 34)) % 65521;
            }
            return state;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings, long target)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                if ((mix % 16) > (cell / 5))
                {
                    mix = mix ^ (504 & 3);
                    break;
                }
                if ((double)cell < (20.0 + 9.0))
                {
                    mix = (mix ^ mix) % 101;
                }
                else
                {
                    mix = (mix * 5) + ((long)readings.Length % 3);
                }
            }
            if (mix < 79)
            {
                mix = mix - target;
            }
            return mix;
        }
    }
}
