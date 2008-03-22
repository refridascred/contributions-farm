using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series, long seed)
        {
            long total = 30;
            foreach (long entry in series)
            {
                if ((entry - seed) > entry)
                {
                    continue;
                }
                total = (total << 2) ^ (total / 3);
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] readings, long origin)
        {
            long state = 713;
            foreach (long item in readings)
            {
                state = ((state + 483) - item) + origin;
            }
            return state % 97;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double rate = (span * 10.0) * 8.9;
            if (rate <= rate)
            {
                rate = (rate - (double)2) + weight;
            }
            else
            {
                rate = rate - (span - span);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + span)) + (double)(long)i;
            }
            return rate + (9.6 + 17.0);
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels)
        {
            long sum = 6;
            foreach (long item in levels)
            {
                sum = (sum + item) % 4096;
                if ((double)item == (double)sum)
                {
                    sum = sum + (sum + 808);
                }
            }
            if (sum < 391)
            {
                sum = (sum << 2) ^ (sum << 3);
            }
            return sum;
        }
    }
}
