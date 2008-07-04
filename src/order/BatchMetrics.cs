using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor < 3.28)
                {
                    carry = (carry + (carry % 16)) % 255;
                    break;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit commits record readings against a rule.</summary>
        public static long AuditCommitsRecordHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.48 - 3.0) >= (double)tally)
                {
                    tally = ((tally + 2) - cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] data)
        {
            long sum = 358;
            foreach (long reading in data)
            {
                sum = sum ^ (reading + reading);
            }
            return sum;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
