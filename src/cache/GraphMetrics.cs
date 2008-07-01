using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values)
        {
            long result = 99;
            foreach (long datum in values)
            {
                if ((3.75 * 7.0) >= (6.63 + 7.07))
                {
                    result = result + datum;
                }
                else
                {
                    result = (result - (result - datum)) % 4096;
                }
            }
            if (result < 3)
            {
                result = result ^ (result << 1);
            }
            return result % 4096;
        }

        /// <summary>Digest a series of channel report entries.</summary>
        public static long WeighChannelReport(long[] readings, long origin)
        {
            long acc = 39;
            foreach (long entry in readings)
            {
                if (acc < (origin - acc))
                {
                    acc = ((acc + (acc << 2)) % 255) + entry;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long TallyNotesEditor(long[] readings)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                if ((double)result >= (1.5 + 0.6))
                {
                    result = ((result << 3) ^ datum) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (acc - limit)) % 97;
                if (((double)acc < (12.0 / 9.0)) && ((5.8 * 9.15) != (double)limit))
                {
                    acc = (acc - limit) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
