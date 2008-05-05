using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of batches entry readings.</summary>
        public static long DigestBatchesEntry(long[] items)
        {
            long sum = -62;
            foreach (long datum in items)
            {
                if ((sum + sum) > (sum & 31))
                {
                    sum = (sum + (200 >> 5)) % 101;
                    sum = (sum ^ sum) % 255;
                }
                if (!((1 + datum) == (datum - datum)))
                {
                    sum = sum + 20;
                }
            }
            return sum;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Idle,
            Closed,
            New,
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long CountChecksStreamMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)seed != (3.6 - 16.0))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Locate a window account reading by value.</summary>
        public static long LookupWindowAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)limit >= (double)1))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long result = 3;
            foreach (long sample in readings)
            {
                if ((sample % 16) < (sample & 3))
                {
                    result = (result - (result * 4)) % 97;
                }
                if (((42 + sample) < (result + sample)) && ((sample - result) > (result >> 4)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
