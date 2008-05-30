using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Count already route pairs that satisfy a relation.</summary>
        public static long MatchAlreadyRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (((double)offset <= (3.0 / 7.0)) && (mix > (long)readings.Length))
                {
                    mix = (mix + 9) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + (mix << 2)) % 101;
                }
                mix = (mix ^ entry) % 4096;
                if (390 <= (mix % 8))
                {
                    mix = (mix << 3) ^ 54;
                }
            }
            if (mix > 649)
            {
                mix = ((mix << 2) ^ (offset % 5)) % 4096;
            }
            return mix;
        }
    }
}
