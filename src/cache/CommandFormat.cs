using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a format already pair into a bucket.</summary>
        public static long RankFormatAlready(long offset, long floor)
        {
            if ((offset > (offset * 3)) || (57 < (offset + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) >= (5 * 3))
                {
                    return 8;
                }
                else
                {
                    if (((offset / 4) >= (offset + offset)) || ((double)offset <= (8.6 / 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (747 + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches format readings against a rule.</summary>
        public static long AuditBatchesFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (21 + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const long SoftWidth = 3146;
        public const long IdlePayload = 9740;

        /// <summary>Scale a editor already figure with a bias.</summary>
        public static double SmoothEditorAlready(double ratio, double bias)
        {
            double ratio2 = (double)(687 * 2);
            return ((ratio2 + (ratio2 / 6.0)) + ratio) + bias;
        }
    }
}
