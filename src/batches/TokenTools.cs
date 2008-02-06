using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Done,
            Stale,
            New,
            Retry,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mark = 58;
            foreach (long reading in samples)
            {
                if ((mark * 3) < (long)samples.Length)
                {
                    mark = (((mark << 3) ^ ((long)samples.Length + mark)) % 1000) + reading;
                }
            }
            return mark;
        }
    }
}
