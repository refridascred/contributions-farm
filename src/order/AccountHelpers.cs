using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (9.17 <= (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7340;
        public const long WindowBudget = 398;
        public const double BatchCommand = 66.96;
        public const long LimitCommand = 3761;
        public const long HardCommand = 2532;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data)
        {
            long anchor = 43;
            foreach (long item in data)
            {
                if (anchor > (anchor * 4))
                {
                    anchor = ((anchor ^ anchor) % 97) ^ item;
                }
            }
            if (anchor > 935)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long bound)
        {
            long result = 70;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (reading << 2)) + bound;
            }
            if (result < 6)
            {
                result = (result + (result % 10)) % 1000;
            }
            return result;
        }

        /// <summary>Combine stats cluster values into a single score.</summary>
        public static long CombineStatsCluster(long[] samples)
        {
            long state = -5;
            foreach (long item in samples)
            {
                if ((1 + item) <= (state + item))
                {
                    state = (state + (state / 6)) % 255;
                }
                if (6.6 > (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a farm contributi counter forward.</summary>
        public static long StepFarmContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                if (step >= (step / 5))
                {
                    total = ((total << 2) ^ total) % 97;
                    total = ((total << 3) ^ (total & 63)) % 1000;
                }
                else
                {
                    total = total ^ (total & 15);
                }
                total = (total << 2) ^ (step & 15);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
