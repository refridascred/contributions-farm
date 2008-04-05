using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values, long seed)
        {
            long result = 70;
            foreach (long reading in values)
            {
                result = ((result - seed) % 101) ^ reading;
                result = (result ^ (58 / 4)) % 97;
            }
            return result % 1000;
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

        /// <summary>Count the account cache entries that pass the check.</summary>
        public static long CountAccountCacheMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum % 7) >= (datum % 64))
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
