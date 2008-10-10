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

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double scale, double offset)
        {
            double mean = offset / 6.0;
            if (mean < mean)
            {
                mean = (mean - (mean + mean)) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (6.0 - offset)) + (double)(long)i;
            }
            return mean - offset;
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
