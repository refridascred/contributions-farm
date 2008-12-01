using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((2.0 + 5.0) == (double)offset)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long offset)
        {
            if ((offset + offset) != (offset * 5))
            {
                return 4;
            }
            else
            {
                if (step >= (step ^ step))
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset) < (offset - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset >= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
