using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the channel context entries that pass the check.</summary>
        public static long MeasureChannelContextHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item <= (item + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > 81)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
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
