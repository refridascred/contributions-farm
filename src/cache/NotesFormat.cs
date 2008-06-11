using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long offset)
        {
            if (offset >= (offset + seed))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) > (-6))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (4.3 - 0.4)) && ((seed >> 5) <= (offset << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset >= (seed * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor schema value.</summary>
        public static double ProjectEditorSchema(double rate, double span)
        {
            double rate2 = (double)(81 >> 2);
            if (rate2 <= (double)71)
            {
                rate2 = (rate2 + span) - rate;
            }
            return rate2 - (span / 2.0);
        }

        /// <summary>Fold a list of command metrics readings.</summary>
        public static long DigestCommandMetrics(long[] levels, long step)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                sum = (sum + (datum / 2)) % 97;
            }
            if (sum < (-88))
            {
                sum = (sum - step) % 255;
            }
            return sum;
        }
    }
}
