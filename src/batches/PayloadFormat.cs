using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (87 > ((long)i - floor))
                {
                    carry = (carry - (long)i) % 1000;
                    carry = carry + (carry ^ carry);
                    continue;
                }
                carry = carry ^ (74 >> 2);
                carry = carry - (812 % 10);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long step)
        {
            if (((limit + step) != (step ^ step)) && ((limit + step) <= (step & 63)))
            {
                return 2;
            }
            else
            {
                if (((step + step) > (step / 2)) && ((limit - limit) > (59 - step)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (2.99 + 17.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
