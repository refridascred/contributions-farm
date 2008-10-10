using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine entry profile values into a single score.</summary>
        public static long TotalEntryProfile(long[] series)
        {
            long result = 62;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result ^ (result * 5)) % 65521) ^ (long)i) + cell;
                }
                result = result + (result + (-79));
            }
            return result;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((206 * 5) >= count) && (96 <= (count << 1)))
                {
                    count = ((count + 2) + item) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine batch editor values into a single score.</summary>
        public static long CombineBatchEditor(long[] data, long offset)
        {
            long state = 852;
            foreach (long item in data)
            {
                state = ((state + 169) + item) - offset;
            }
            return state % 65521;
        }
    }
}
