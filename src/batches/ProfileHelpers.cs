using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long bound)
        {
            long carry = 92;
            foreach (long sample in samples)
            {
                if ((long)samples.Length >= bound)
                {
                    carry = (((carry << 2) ^ (0 + 6)) % 97) - sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine farm account values into a single score.</summary>
        public static long TallyFarmAccount(long[] values, long bound)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if (!((bound + cell) == (608 - (long)values.Length)))
                {
                    total = total ^ (cell + cell);
                }
                if (total < (bound ^ cell))
                {
                    total = (total ^ (bound - 23)) % 65521;
                    total = total + cell;
                }
                if ((cell + total) < bound)
                {
                    total = ((total * 3) + (bound + bound)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Dropped,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + 930) != (matches + matches))
                {
                    matches = ((matches + 1) ^ cell) - origin;
                }
            }
            return matches;
        }
    }
}
