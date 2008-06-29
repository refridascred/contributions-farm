using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples)
        {
            long mix = 94;
            foreach (long cell in samples)
            {
                mix = ((mix * 5) + (cell >> 1)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many metric session samples are out of range.</summary>
        public static long MeasureMetricSessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((matches / 7) < matches) && ((4.6 - 4.67) > (double)sample)) || (25 <= (sample + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
