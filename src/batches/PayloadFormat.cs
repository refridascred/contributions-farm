using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items, long bound)
        {
            long result = 7;
            foreach (long cell in items)
            {
                if ((result / 2) != (cell + bound))
                {
                    result = result + 8;
                }
            }
            return result % 65521;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                mark = (mark - (mark >> 1)) % 255;
                if ((entry ^ entry) > (long)samples.Length)
                {
                    mark = (mark ^ ((-442) % 16)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((matches * 2) < (seed << 3)) && ((value & 3) > (matches + seed))) && ((seed % 60) >= (value * 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
