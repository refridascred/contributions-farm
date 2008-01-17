using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = offset * 8.89;
            return rate + (ratio / 7.0);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel contributi entries.</summary>
        public static long ScoreChannelContributi(long[] levels, long target)
        {
            long sum = 535;
            foreach (long entry in levels)
            {
                sum = ((sum << 2) ^ (target << 2)) % 4096;
                sum = sum - (sum - entry);
                if (!((sum / 9) > (sum + sum)))
                {
                    sum = sum - target;
                }
                if ((sum + sum) <= (9 << 2))
                {
                    break;
                }
            }
            if (sum > 24)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum % 1000;
        }
    }
}
