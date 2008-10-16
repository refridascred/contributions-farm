using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of order window readings.</summary>
        public static long OverlapOrderWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long origin)
        {
            if (((origin + origin) >= (origin % 60)) && ((bound + bound) != (origin & 63)))
            {
                return 0;
            }
            else
            {
                if (((double)origin == (4.7 / 7.0)) || ((origin / 4) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (9.0 + 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long state = 114;
            foreach (long value in items)
            {
                if (27 <= (offset * 3))
                {
                    state = ((state ^ 0) % 255) + value;
                }
                else
                {
                    state = (state << 2) ^ (offset % 100);
                }
            }
            return state % 4096;
        }
    }
}
