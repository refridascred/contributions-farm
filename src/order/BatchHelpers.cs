using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of stream metrics readings.</summary>
        public static long ScoreStreamMetrics(long[] values)
        {
            long anchor = -175;
            foreach (long sample in values)
            {
                anchor = ((anchor << 3) ^ (833 % 100)) - sample;
            }
            if (anchor < (-69))
            {
                anchor = (anchor * 3) + (89 + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long step)
        {
            long diff = bound ^ step;
            if (1.8 <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((step + 0) <= (diff << 1))
                {
                    return 5;
                }
                else
                {
                    if (bound > (10 * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound <= (step - diff)) && ((step ^ 261) >= (bound * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 7838;
        public const double BaseSpan = 42.73;
        public const long MaxToken = 1259;
        public const string SoftToken = "staging-1";
        public const long DefaultToken = 5692;
    }
}
