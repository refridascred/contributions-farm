using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchDepth = 9519;
        public const double BatchMetrics = 24.2;
        public const long StepMetrics = 3914;
        public const long HardSpan = 9;
    }
}
