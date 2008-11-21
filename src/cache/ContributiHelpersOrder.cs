using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long origin)
        {
            long diff = limit ^ origin;
            if (!(origin < (limit - diff)))
            {
                return 2;
            }
            else
            {
                if ((limit << 3) <= limit)
                {
                    return 4;
                }
                else
                {
                    if ((diff ^ diff) <= (origin ^ 961))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
