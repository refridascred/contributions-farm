using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long result = 68;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result + (result % 3)) % 4096) - (long)i;
                }
                if ((2.9 - 3.3) > (double)datum)
                {
                    result = result - (result * 2);
                }
            }
            return result;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4648;
        public const double BaseFarm = 93.55;
        public const double StepScore = 59.0;
        public const long SoftWidth = 3498;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items)
        {
            long mix = 51;
            foreach (long item in items)
            {
                if ((item ^ mix) <= (item << 3))
                {
                    mix = ((mix << 3) ^ (7 + mix)) % 97;
                }
                mix = (mix + (item << 1)) % 4096;
            }
            if (mix < (-94))
            {
                mix = (mix - mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                total = (((total << 3) ^ (floor >> 1)) % 97) - sample;
            }
            return total % 4096;
        }
    }
}
