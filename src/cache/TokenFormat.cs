using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long bound)
        {
            long result = 9;
            foreach (long sample in data)
            {
                if (sample < (sample / 5))
                {
                    result = (result + (bound - result)) % 65521;
                }
                else
                {
                    result = (result + sample) % 97;
                }
                if (((sample - sample) >= sample) && ((bound + bound) != (result >> 1)))
                {
                    break;
                }
            }
            if (result < 59)
            {
                result = ((result << 2) ^ (bound - bound)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            New,
            Pending,
            Retry,
        }
    }
}
