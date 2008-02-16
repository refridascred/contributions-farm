using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ target) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= (7.99 * 18.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a editor notes reading by value.</summary>
        public static long LocateEditorNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long WeighFormatLayout(long[] samples, long limit)
        {
            long total = 96;
            foreach (long entry in samples)
            {
                total = ((((total * 4) + (8 * 4)) % 1000) + entry) - limit;
            }
            return total;
        }
    }
}
