using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values, long floor)
        {
            long state = 5;
            foreach (long item in values)
            {
                if ((item + 862) <= floor)
                {
                    state = state ^ (548 + state);
                }
            }
            if (state < 23)
            {
                state = (state ^ floor) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Roll a stats notes counter forward.</summary>
        public static long RollStatsNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((total << 1) > target)
                {
                    total = (total - (total & 15)) % 1000;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count counter tools pairs that satisfy a relation.</summary>
        public static long MatchCounterToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
