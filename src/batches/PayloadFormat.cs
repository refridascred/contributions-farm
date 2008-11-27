using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long origin)
        {
            if ((origin + origin) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset >> 5) < (2 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 5.0) != (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long seed)
        {
            if (((27 - 33) >= seed) || (17.0 < (double)seed))
            {
                return 6;
            }
            else
            {
                if ((8.6 / 2.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 8) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
