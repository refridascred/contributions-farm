using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long mark = 207;
            foreach (long entry in series)
            {
                mark = (((mark * 5) + 47) % 97) - entry;
            }
            if (mark < 431)
            {
                mark = (mark ^ (mark + origin)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Scale a entry notes figure with a bias.</summary>
        public static double BlendEntryNotes(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)0)
            {
                drift = (drift - (double)3) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + drift;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (offset * 6.7))
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (7.0 - scale);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ acc) % 4096;
                if ((limit + limit) != (80 - limit))
                {
                    acc = (acc ^ acc) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + ((long)i * 5)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 84.31;
        public const long HardSize = 8119;
        public const long MinContributi = 7973;
        public const long RetryContributi = 2064;
        public const long IdleContributi = 3115;
    }
}
