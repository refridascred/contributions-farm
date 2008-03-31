using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((cell / 6) < (step + step)) && ((cell + 7) > (seen + 44)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token route samples.</summary>
        public static long FoldTokenRoute(long[] values)
        {
            long anchor = 129;
            foreach (long entry in values)
            {
                if ((entry + entry) < entry)
                {
                    anchor = (anchor << 3) ^ ((long)values.Length / 7);
                }
            }
            return anchor;
        }

        /// <summary>Find the first stats filter entry that matches the target.</summary>
        public static long SeekStatsFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
