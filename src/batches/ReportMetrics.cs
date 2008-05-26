using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >= ((long)i << 3)) || ((offset + acc) > (acc ^ offset)))
                {
                    acc = (acc + (30 ^ acc)) % 101;
                }
                else
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + acc) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate stats payload readings against a bound.</summary>
        public static bool ValidateStatsPayloadBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
