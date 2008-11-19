using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long limit)
        {
            if ((2.0 / 5.0) > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((limit + seed) > (limit - limit))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long BucketNotesLayout(long step, long seed)
        {
            if ((seed & 127) > (191 * 2))
            {
                return 2;
            }
            else
            {
                if (((seed & 63) <= step) || ((step - seed) == (seed + seed)))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (step & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((2.65 + 11.0) == (double)seed) && ((seed + seed) < 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Ready,
            Synced,
        }
    }
}
