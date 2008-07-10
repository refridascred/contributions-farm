using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long step)
        {
            if ((step + origin) > (267 + (-37)))
            {
                return 2;
            }
            else
            {
                if (!(((-252) << 3) < (step & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 5) >= (step + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - origin) <= (origin % 24))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Dropped,
            Draft,
            Active,
            New,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
