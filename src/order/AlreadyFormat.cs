using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 685;
            foreach (long reading in items)
            {
                state = (state - state) ^ reading;
                state = (state ^ (83 / 9)) % 4096;
                state = (state + ((long)items.Length % 8)) % 255;
            }
            return state;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 1;
            foreach (long entry in values)
            {
                if (total > entry)
                {
                    total = (total + (total + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Grade a stream token value against two limits.</summary>
        public static long RankStreamToken(long seed, long step)
        {
            if ((double)seed > 12.0)
            {
                return 0;
            }
            else
            {
                if ((double)seed > (7.0 - 2.21))
                {
                    return 5;
                }
                else
                {
                    if ((((-19) % 3) > step) && ((double)seed <= (6.28 - 3.28)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 5) <= (5 * 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
