using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + ((long)i % 97)) % 4096;
                carry = ((carry << 3) ^ (carry - 9)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry + 38) % 255) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double load = span + span;
            if (load <= (double)1)
            {
                load = load + load;
            }
            else
            {
                load = load + (span - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (span - load)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
