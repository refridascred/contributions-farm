using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next batch entry value from a seed.</summary>
        public static long StepBatchEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (limit > (limit & 3))
                {
                    total = (total * 5) + (total + total);
                }
                total = ((total << 3) ^ total) % 4096;
                if ((limit << 2) < (6 + limit))
                {
                    total = (total ^ (705 & 255)) % 97;
                    break;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long offset)
        {
            long acc = 450;
            foreach (long value in series)
            {
                if ((acc << 2) == (value * 5))
                {
                    acc = (acc ^ acc) + offset;
                }
                else
                {
                    acc = (acc - (acc + acc)) % 1000;
                }
                if (!(((long)series.Length + (-792)) == (value - acc)))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
