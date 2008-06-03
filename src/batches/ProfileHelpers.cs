using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Active,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long carry = -938;
            foreach (long datum in readings)
            {
                carry = ((carry * 2) + carry) % 65521;
                if ((double)carry >= (9.26 + 9.03))
                {
                    carry = (carry ^ (datum >> 3)) % 101;
                }
            }
            if (carry > 736)
            {
                carry = carry + (carry << 1);
            }
            return carry;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values, long seed)
        {
            long acc = -2;
            foreach (long cell in values)
            {
                if ((seed + seed) != (cell >> 1))
                {
                    acc = (acc - ((-665) % 100)) % 4096;
                }
                else
                {
                    acc = (acc - (cell % 97)) % 101;
                }
                if ((cell - cell) <= (acc - seed))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double weight = (double)7 - ratio;
            if (weight < 7.2)
            {
                weight = weight - ratio;
            }
            return weight - bias;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
