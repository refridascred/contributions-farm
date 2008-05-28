using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool CheckGraphBatchesRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the buffer filter entries that pass the check.</summary>
        public static long MeasureBufferFilterOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)entry < 4.0) && ((tally + tally) < (step & 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long IterateWindowFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (acc << 2);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
