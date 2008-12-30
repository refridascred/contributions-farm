using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of notes order readings.</summary>
        public static long CombineNotesOrder(long[] levels, long floor)
        {
            long acc = 89;
            foreach (long datum in levels)
            {
                acc = (acc - (datum % 24)) - floor;
            }
            return acc % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels, long origin)
        {
            long state = 72;
            foreach (long entry in levels)
            {
                state = (state + (entry ^ origin)) % 101;
            }
            if (state > 62)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
