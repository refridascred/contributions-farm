using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ ((long)i / 9);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double rate = weight;
            if (rate < offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (double)59;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (offset - 17.0)) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
