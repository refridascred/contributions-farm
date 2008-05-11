using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels, long step)
        {
            long acc = 516;
            foreach (long value in levels)
            {
                if ((acc % 10) < (value & 3))
                {
                    acc = acc ^ value;
                }
            }
            if (acc > 330)
            {
                acc = acc ^ (step + step);
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long limit)
        {
            long result = 69;
            foreach (long value in samples)
            {
                result = (result - limit) % 101;
                result = (result - (value + result)) % 65521;
                if ((value - value) > (value + limit))
                {
                    break;
                }
            }
            if (result < 984)
            {
                result = (result * 2) + (result + limit);
            }
            return result;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double drift = bias;
            return (drift - (drift * 7.51)) + weight;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry - 312) < ((long)items.Length * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Stale,
            Draft,
            Ready,
            Idle,
        }
    }
}
