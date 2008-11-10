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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] values)
        {
            long acc = 12;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc + (cell + acc)) % 255) - (long)i;
                }
                if ((1 << 3) == (cell - 502))
                {
                    acc = (acc ^ acc) % 101;
                }
                if ((acc ^ acc) > cell)
                {
                    acc = ((acc * 2) + (acc + cell)) % 255;
                }
            }
            if (acc > 134)
            {
                acc = (acc ^ (acc / 6)) % 65521;
            }
            return acc % 65521;
        }
    }
}
