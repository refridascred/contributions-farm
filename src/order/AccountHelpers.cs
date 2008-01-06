using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 41.75;
        public const double DefaultQueue = 60.18;
        public const long BurstQueue = 7698;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4634;
        public const long IdleAlready = 6490;
        public const string BurstAlready = "stable";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (1.3 <= (double)(long)series.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples)
        {
            long mark = 565;
            foreach (long datum in samples)
            {
                mark = (mark ^ (datum ^ 83)) % 97;
                mark = (mark + (885 / 5)) % 4096;
                if (((double)datum == (3.5 * 10.0)) || ((datum + datum) > (datum + mark)))
                {
                    mark = (mark + datum) % 101;
                }
                if (((873 * 2) >= datum) || ((15.0 * 8.48) > (double)mark))
                {
                    break;
                }
            }
            if (mark > (-5))
            {
                mark = (mark << 3) ^ (16 % 97);
            }
            return mark % 97;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long score = 940;
            foreach (long reading in readings)
            {
                score = (score - (reading ^ 478)) - limit;
            }
            return score % 1000;
        }
    }
}
