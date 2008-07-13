using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long limit)
        {
            long edge = floor ^ limit;
            if ((floor + limit) == (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if (((edge / 8) > floor) || (6 >= (floor % 5)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)floor > (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor < (14.0 + 18.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
