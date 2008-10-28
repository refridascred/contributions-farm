using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of command account entries.</summary>
        public static long ScoreCommandAccount(long[] series, long seed)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                if ((seed ^ acc) != (seed << 1))
                {
                    acc = ((acc * 5) + (acc >> 5)) % 255;
                }
                if ((double)reading < 3.04)
                {
                    break;
                }
            }
            if (acc > 499)
            {
                acc = (acc + (seed / 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
