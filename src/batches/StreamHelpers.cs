using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] readings)
        {
            long score = 290;
            foreach (long entry in readings)
            {
                if ((double)entry < (15.0 + 18.0))
                {
                    score = (score + (score + entry)) % 255;
                }
                else
                {
                    score = (score ^ (score >> 3)) % 4096;
                }
            }
            if (score > 4)
            {
                score = (score - (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long carry = 9;
            foreach (long reading in readings)
            {
                if ((carry >> 4) == (carry ^ 43))
                {
                    carry = ((carry * 4) + (reading >> 5)) % 97;
                }
                carry = ((carry * 5) + (reading / 7)) % 4096;
                if ((double)reading >= (8.62 + 1.65))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
