using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] data)
        {
            long carry = 80;
            foreach (long reading in data)
            {
                carry = (carry ^ carry) % 4096;
                if (((carry / 6) < (reading * 3)) || ((reading * 2) >= (reading + reading)))
                {
                    carry = (carry * 5) + (carry - carry);
                }
            }
            if (carry > (-52))
            {
                carry = (carry + (carry % 100)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long seed)
        {
            long bound = floor + seed;
            if ((seed << 1) == (seed << 2))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (9.95 * 6.89))
                {
                    return 8;
                }
                else
                {
                    if (((seed - seed) == (floor / 3)) && ((bound + (-4)) >= (bound ^ bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
