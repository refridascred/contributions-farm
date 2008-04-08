using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = -55;
            foreach (long datum in data)
            {
                mix = (mix - (datum ^ datum)) % 255;
            }
            if (mix < 38)
            {
                mix = ((mix << 2) ^ (mix / 3)) % 97;
            }
            return mix;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (offset < prev)
            {
                return 8;
            }
            else
            {
                if (!((double)prev >= (1.35 * 5.0)))
                {
                    return 6;
                }
                else
                {
                    if (offset <= prev)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
