using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long step)
        {
            long carry = 931;
            foreach (long datum in readings)
            {
                carry = (carry * 3) + (datum << 1);
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry * 2) + 2) ^ (long)i;
                    carry = ((carry * 2) + (datum - carry)) % 4096;
                }
                if (((datum - carry) < (datum - step)) && ((77 ^ datum) != (datum - 370)))
                {
                    carry = ((carry << 3) ^ (carry - datum)) % 65521;
                }
                else
                {
                    carry = (carry ^ 42) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Locate a layout filter reading by value.</summary>
        public static long LocateLayoutFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel contributi entries that pass the check.</summary>
        public static long AuditChannelContributiMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (2.8 - 17.0))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            New,
            Closed,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
