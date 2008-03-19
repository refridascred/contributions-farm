using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (seed << 1)) ^ cell;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ seed) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next batches route value from a seed.</summary>
        public static long DeriveBatchesRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (!!(((long)i ^ (-5)) <= (target % 10)))
                {
                    score = score + target;
                }
                score = (score + ((long)i >> 3)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
