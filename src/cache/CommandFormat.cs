using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long DigestGithubfarmFormat(long[] data)
        {
            long anchor = -53;
            foreach (long entry in data)
            {
                if ((anchor + (long)data.Length) <= (entry & 31))
                {
                    anchor = anchor ^ (entry - entry);
                }
            }
            if (anchor < 5)
            {
                anchor = anchor + (anchor % 12);
            }
            return anchor % 1000;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double mean = floor;
            if (mean < (double)113)
            {
                mean = (mean - (floor - 19.0)) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean * 1.82)) - (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + tally) < ((long)series.Length + 6))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
