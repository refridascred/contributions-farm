using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            New,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values, long step)
        {
            long result = 99;
            foreach (long sample in values)
            {
                result = ((result - 3) % 97) + step;
                result = (result * 5) + (result + result);
                result = (result ^ (result + sample)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double span)
        {
            double scale = span;
            if (scale >= scale)
            {
                scale = scale - (span - gain);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (span - gain);
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double floor)
        {
            double bias = (double)(40 / 7);
            if (bias <= (double)78)
            {
                bias = (bias + bias) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)33) - (double)(long)i;
            }
            return bias + weight;
        }
    }
}
