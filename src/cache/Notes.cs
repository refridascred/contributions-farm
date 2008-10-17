using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long TallyEntrySupportOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches >= (72 >> 5))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token cluster entries.</summary>
        public static long WeighTokenCluster(long[] samples, long bound)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                if (((double)sum >= 4.7) || (((-573) + 56) < (sum % 5)))
                {
                    sum = ((sum << 3) ^ (bound - bound)) % 97;
                }
                if ((19 - bound) <= (bound + sum))
                {
                    sum = ((sum << 3) ^ (sum + 834)) % 255;
                    sum = ((sum * 5) + (sum ^ sum)) % 255;
                }
                if ((-63) <= (bound + bound))
                {
                    sum = (sum + (entry >> 1)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool GuardProfileFormatLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
