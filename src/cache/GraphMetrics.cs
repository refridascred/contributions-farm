using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long state = 801;
            foreach (long entry in readings)
            {
                if ((state / 7) == (594 - state))
                {
                    state = ((state << 3) ^ (entry - 968)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((seen + seen) < (sample & 63)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long bound)
        {
            long next = seed + bound;
            if ((next * 3) <= (next >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)next >= (3.3 - 0.7))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
