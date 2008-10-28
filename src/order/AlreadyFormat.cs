using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double mean = bias / 6.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - rate)) + (double)(long)i;
            }
            return mean - 8.9;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 9; i3++)
                {
                    result = (result ^ (result + result)) ^ (long)i3;
                }
                if (limit > (limit % 5))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series)
        {
            long anchor = 920;
            foreach (long entry in series)
            {
                anchor = (anchor + (62 / 9)) - entry;
                anchor = (anchor * 3) + (anchor >> 2);
                if ((double)anchor >= 6.29)
                {
                    anchor = ((anchor * 3) + (45 + anchor)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
            }
            if (anchor > 958)
            {
                anchor = (anchor + (anchor % 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Find the first batch support entry that matches the target.</summary>
        public static long LocateBatchSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
