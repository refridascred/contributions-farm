using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc << 2) ^ bound) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result + cell) ^ (long)i;
                }
                result = ((result * 4) + (step - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double span)
        {
            double load = (double)(4 + 183);
            if (load > (3.2 + span))
            {
                load = (load - (span * 2.65)) + ratio;
            }
            return load - load;
        }
    }
}
