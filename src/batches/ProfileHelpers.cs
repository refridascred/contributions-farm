using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long carry = 111;
            foreach (long value in levels)
            {
                if ((double)value != (double)carry)
                {
                    carry = carry + ((long)levels.Length % 60);
                }
            }
            if (carry > (-7))
            {
                carry = (carry ^ (carry % 24)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a context farm reading.</summary>
        public static double AdjustContextFarm(double scale, double offset)
        {
            double weight = 17.0 / 7.0;
            if (weight < weight)
            {
                weight = weight + 20.0;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (scale * 14.0)) + (double)(long)i;
            }
            return weight + (offset / 8.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitFactor = 9116;
        public const long LimitRatio = 2478;
        public const long LimitBuffer = 9961;

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double drift = (offset - 8.37) * 7.12;
            if (drift > offset)
            {
                drift = drift + (double)9;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + offset;
        }
    }
}
