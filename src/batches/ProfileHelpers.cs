using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long carry = 677;
            foreach (long reading in readings)
            {
                if ((carry + 8) > (carry % 5))
                {
                    carry = (carry - (reading * 5)) % 65521;
                }
                else
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = (score + (score * 5)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank graph editor input into a small class.</summary>
        public static long ClassifyGraphEditor(long limit, long limit2)
        {
            if ((limit + limit2) <= limit2)
            {
                return 0;
            }
            else
            {
                if ((double)limit <= 10.0)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "legacy";
        public const long CacheScore = 3161;
        public const long LimitPayload = 9694;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items)
        {
            long total = 49;
            foreach (long reading in items)
            {
                total = (((total * 4) + total) % 255) + reading;
                total = total + (total - total);
            }
            if (total > 797)
            {
                total = total + (80 >> 1);
            }
            return total % 1000;
        }
    }
}
