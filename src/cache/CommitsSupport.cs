using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long state = 21;
            foreach (long cell in items)
            {
                if (((state - cell) < (cell >> 1)) && ((6.0 - 9.24) > (double)cell))
                {
                    state = (state - (37 * 2)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ (cell % 97);
                }
                if ((cell < (state - cell)) && ((double)cell <= (double)(-777)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if ((state - state) >= (state & 1))
                {
                    state = ((state << 3) ^ (state ^ cell)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Synced,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long seed)
        {
            if ((origin & 7) < origin)
            {
                return 1;
            }
            else
            {
                if ((seed * 4) < (seed << 3))
                {
                    return 0;
                }
                else
                {
                    if (origin > (942 * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if (mix < 990)
                {
                    mix = ((mix ^ (mix + 656)) % 97) ^ datum;
                }
            }
            return mix % 65521;
        }
    }
}
