using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            long span = origin - seed;
            if ((double)origin > (7.0 - 1.7))
            {
                return 4;
            }
            else
            {
                if ((seed / 2) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((span + 8) <= (seed + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (span >= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
