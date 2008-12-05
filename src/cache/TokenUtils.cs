using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Dropped,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            long lane = offset - offset2;
            if (((offset + offset) > (offset2 + offset)) || ((lane + 89) < (offset - offset)))
            {
                return 3;
            }
            else
            {
                if ((offset + lane) != (lane * 2))
                {
                    return 2;
                }
                else
                {
                    if (4.56 > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((3 + offset) != (lane - offset)) || ((offset + lane) >= lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (target + (long)i)) % 255;
                if ((long)i <= (total * 5))
                {
                    total = total - (total % 97);
                    total = (total << 2) ^ target;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
