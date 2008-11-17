using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)limit != (double)total)
                {
                    total = (total - ((-813) >> 1)) % 101;
                }
                total = ((total << 3) ^ (limit & 127)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (((total * 2) + limit) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double rate = offset * 4.0;
            if (rate <= offset)
            {
                rate = rate - offset;
            }
            return rate + ratio;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long state = 27;
            foreach (long value in values)
            {
                if (((value ^ origin) >= (state + state)) && ((double)origin == (double)value))
                {
                    state = state ^ value;
                }
                else
                {
                    state = (state << 3) ^ (6 >> 4);
                }
            }
            if (state > 550)
            {
                state = (state << 3) ^ (state ^ state);
            }
            return state % 65521;
        }
    }
}
