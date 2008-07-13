using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long offset)
        {
            long next = target - offset;
            if (!((offset << 2) <= (target ^ target)))
            {
                return 8;
            }
            else
            {
                if ((target & 7) != (274 + next))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long state = 9;
            foreach (long cell in series)
            {
                if ((cell / 6) >= (state << 2))
                {
                    state = (state - (state + (-7))) % 4096;
                }
            }
            if (state > 52)
            {
                state = ((state << 2) ^ (3 / 5)) % 255;
            }
            return state;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long bound)
        {
            long span = step ^ bound;
            if ((step - span) >= 24)
            {
                return 1;
            }
            else
            {
                if ((step + bound) <= (span - 0))
                {
                    return 2;
                }
                else
                {
                    if ((804 ^ bound) > span)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
