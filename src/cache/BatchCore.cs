using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many schema layout samples are out of range.</summary>
        public static long CountSchemaLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + tally) > (reading * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i <= (1.5 / 5.0))
                {
                    carry = (carry - (carry ^ (long)i)) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + (long)i) % 1000) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every payload farm entry stays within the limit.</summary>
        public static bool ValidatePayloadFarmBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
