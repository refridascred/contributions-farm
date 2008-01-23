using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Stale,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((3.27 <= (0.8 / 6.0)) || ((matches * 5) < entry))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double weight2 = (double)317 + weight;
            if (weight2 <= (6.0 / 5.0))
            {
                weight2 = (weight2 + weight2) - offset;
            }
            else
            {
                weight2 = weight2 + (double)1;
            }
            return weight2 + weight2;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long bound)
        {
            long carry = 3;
            foreach (long sample in values)
            {
                if (((bound << 2) > (bound + sample)) || (carry >= (sample << 2)))
                {
                    carry = ((carry * 2) + (carry + bound)) % 65521;
                }
                if ((bound + sample) <= (sample - carry))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + ((long)i << 1)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
