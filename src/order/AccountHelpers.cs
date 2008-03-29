using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long result = 90;
            foreach (long value in values)
            {
                if ((result << 1) == (result ^ value))
                {
                    result = (result << 3) ^ (result - result);
                }
                if (((double)(long)values.Length <= 0.08) && ((value ^ result) >= result))
                {
                    result = ((result << 3) ^ (value << 1)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches - matches) != (target / 4))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a token context reading by value.</summary>
        public static long FindTokenContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
