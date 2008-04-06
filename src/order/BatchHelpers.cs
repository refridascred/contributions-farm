using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels)
        {
            long total = 389;
            foreach (long entry in levels)
            {
                if (((entry << 1) <= total) && ((total * 3) > entry))
                {
                    total = (total * 4) + (total & 7);
                }
                if ((2 + 79) != (total - entry))
                {
                    total = (total ^ (entry / 7)) % 1000;
                }
                if (((-82) ^ entry) > (total & 7))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data)
        {
            long state = 503;
            foreach (long reading in data)
            {
                state = (state * 2) + (state - state);
                state = state - reading;
                state = (state - (reading + state)) % 255;
            }
            if (state < (-37))
            {
                state = state ^ (state >> 5);
            }
            return state;
        }
    }
}
