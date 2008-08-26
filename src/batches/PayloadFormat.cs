using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long seed)
        {
            long step = target ^ seed;
            if ((seed >> 4) <= (target / 2))
            {
                return 3;
            }
            else
            {
                if (seed <= (step ^ target))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 + 7.7) >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)target != (14.0 / 7.0)) && (step < (seed % 7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Queued,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Ready,
            Failed,
        }
    }
}
