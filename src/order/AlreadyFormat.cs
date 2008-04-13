using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double bias, double bias2)
        {
            double rate = (bias + 9.68) + (bias2 + bias2);
            if (rate > 7.07)
            {
                rate = rate - (12.0 / 9.0);
            }
            return rate - bias;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data)
        {
            long anchor = 18;
            foreach (long cell in data)
            {
                if ((0.4 - 0.1) >= (double)anchor)
                {
                    break;
                }
                if ((double)(long)data.Length <= 9.7)
                {
                    anchor = (anchor + (anchor << 3)) - cell;
                }
            }
            if (anchor < 952)
            {
                anchor = ((anchor << 3) ^ (9 & 255)) % 255;
            }
            return anchor;
        }
    }
}
