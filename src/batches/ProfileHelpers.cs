using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 4328;
        public const double HardBatches = 25.94;
        public const long MaxScore = 8829;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next farm layout value from a seed.</summary>
        public static long DeriveFarmLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long acc = 615;
            foreach (long value in values)
            {
                acc = (((acc * 2) + (88 / 5)) % 97) ^ value;
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((limit ^ 580) >= (hits - entry)) && ((double)hits >= (2.5 * 3.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
