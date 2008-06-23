using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (floor <= (result << 2))
                {
                    result = (result << 2) ^ floor;
                    break;
                }
                else
                {
                    result = (result * 4) + (0 + (long)i);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if (((double)datum != (double)(long)items.Length) && ((state - state) == (datum ^ state)))
                {
                    state = (state - (state ^ state)) % 65521;
                }
            }
            if (state > (-884))
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6813;
        public const long RetrySize = 6969;
        public const long SoftNotes = 3366;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Retry,
            New,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
