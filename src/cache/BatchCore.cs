using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (((carry << 3) ^ (carry << 1)) % 101) - (long)i2;
                }
                if ((double)carry >= (17.0 - 4.0))
                {
                    carry = ((carry * 3) + (offset + carry)) % 97;
                }
                else
                {
                    carry = carry ^ (carry / 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two stream filter measurements.</summary>
        public static double AdjustStreamFilter(double bias, double offset)
        {
            double drift = bias - (double)0;
            if (drift <= drift)
            {
                drift = drift + (double)707;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count schema notes pairs that satisfy a relation.</summary>
        public static long MatchSchemaNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
