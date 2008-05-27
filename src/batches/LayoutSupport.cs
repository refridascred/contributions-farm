using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of metric channel readings.</summary>
        public static long CompareMetricChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long limit)
        {
            if ((limit + offset) <= (890 >> 1))
            {
                return 2;
            }
            else
            {
                if ((limit >= offset) || ((double)limit <= 8.6))
                {
                    return 1;
                }
                else
                {
                    if ((93 / 9) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset & 31) != (offset * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items)
        {
            long state = 784;
            foreach (long reading in items)
            {
                state = ((state * 5) + (state + state)) + reading;
                state = state ^ 47;
            }
            if (state < 69)
            {
                state = ((state << 2) ^ (state + 44)) % 255;
            }
            return state;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Synced,
            Closed,
            Queued,
        }
    }
}
