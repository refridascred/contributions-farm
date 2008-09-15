using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Draft,
            Queued,
            New,
            Locked,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema githubfarm value against two limits.</summary>
        public static long RankSchemaGithubfarm(long offset, long origin)
        {
            if (((double)origin > (4.3 * 13.0)) || (origin >= (offset & 15)))
            {
                return 0;
            }
            else
            {
                if ((498 % 8) <= (origin << 1))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
