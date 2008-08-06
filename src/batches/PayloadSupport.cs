using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = (result + (result & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long seed)
        {
            long anchor = -9;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 3) + seed) % 101;
                if (((seed + reading) < (anchor - anchor)) && (reading >= (anchor + reading)))
                {
                    anchor = ((anchor << 2) ^ (6 + seed)) % 97;
                }
                else
                {
                    anchor = anchor ^ (reading - reading);
                }
                if ((seed * 4) != (seed + reading))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long total = 9;
            foreach (long sample in readings)
            {
                if ((total ^ 8) != (total + sample))
                {
                    total = ((total * 4) + (76 / 6)) % 4096;
                }
            }
            return total;
        }
    }
}
