using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long ScoreCounterFarm(long[] data)
        {
            long mix = -2;
            foreach (long value in data)
            {
                if ((mix & 63) <= (mix - mix))
                {
                    mix = ((mix << 3) ^ ((long)data.Length - value)) % 65521;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (mix & 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Queued,
            Draft,
            New,
            Ready,
        }
    }
}
