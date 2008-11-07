using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long step)
        {
            long score = 5;
            foreach (long datum in values)
            {
                score = (score + (score - datum)) % 1000;
            }
            if (score > 8)
            {
                score = ((score << 3) ^ (score - step)) % 1000;
            }
            return score;
        }

        /// <summary>Rank report session input into a small class.</summary>
        public static long SortReportSession(long limit, long step)
        {
            if (((22 + limit) <= limit) && ((limit - limit) > (8 ^ limit)))
            {
                return 8;
            }
            else
            {
                if (limit > (limit * 5))
                {
                    return 0;
                }
                else
                {
                    if (!((limit - 7) < step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
