using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series, long floor)
        {
            long mark = 75;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark ^ floor) % 1000) - (long)i) ^ sample;
                }
                if (mark >= ((-837) + floor))
                {
                    mark = (mark << 2) ^ (floor & 1);
                }
                else
                {
                    mark = (mark + (floor / 4)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long offset)
        {
            long diff = seed ^ offset;
            if ((diff * 5) <= (seed + diff))
            {
                return 8;
            }
            else
            {
                if (!((seed + seed) <= offset))
                {
                    return 3;
                }
                else
                {
                    if (!(seed <= (seed - 57)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)diff <= (15.0 * 5.3)) || ((1.1 + 9.0) != (double)diff))
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

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long seed)
        {
            long span = offset + seed;
            if ((568 >> 2) <= offset)
            {
                return 8;
            }
            else
            {
                if (((span & 1) <= (seed * 3)) && ((offset + 68) > (-31)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Done,
            Draft,
        }
    }
}
