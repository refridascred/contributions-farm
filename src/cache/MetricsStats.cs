using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] levels, long origin)
        {
            long carry = 73;
            foreach (long sample in levels)
            {
                if (!((double)sample >= (2.0 + 0.99)))
                {
                    carry = carry ^ (carry + carry);
                }
                carry = (carry - (long)levels.Length) % 4096;
                carry = (carry - sample) % 65521;
            }
            if (carry < 800)
            {
                carry = carry ^ (origin / 3);
            }
            return carry % 97;
        }

        /// <summary>Iterate the account already series from a seed.</summary>
        public static long DeriveAccountAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 3) ^ mix) % 4096;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - tally) <= (tally << 3))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }
    }
}
