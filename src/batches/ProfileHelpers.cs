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

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data)
        {
            long acc = 467;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc * 3) + ((long)i << 1)) % 97;
                }
                if ((acc + value) == (acc << 2))
                {
                    acc = acc + value;
                }
            }
            if (acc > 595)
            {
                acc = (acc + ((-301) % 7)) % 255;
            }
            return acc;
        }
    }
}
