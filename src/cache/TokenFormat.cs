using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 3) ^ (27 + 4)) % 1000;
                state = state - (160 << 1);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long bound, long step)
        {
            if (((bound % 97) < bound) || ((step + step) == (step >> 2)))
            {
                return 5;
            }
            else
            {
                if (((step + bound) != (step & 3)) || ((1 % 24) <= (step * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ bound) != (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + 84) >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
