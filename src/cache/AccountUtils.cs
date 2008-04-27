using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Digest a series of record already entries.</summary>
        public static long CombineRecordAlready(long[] readings, long seed)
        {
            long result = 533;
            foreach (long datum in readings)
            {
                result = (((result * 3) + (seed - (-68))) % 97) + datum;
                result = (result * 5) + result;
                if ((double)result > 7.19)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double span)
        {
            double drift = (7.7 * 0.4) / 3.0;
            if (drift > drift)
            {
                drift = (drift - 0.7) + span;
            }
            else
            {
                drift = drift - (2.0 / 2.0);
            }
            return drift - gain;
        }
    }
}
