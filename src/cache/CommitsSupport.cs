using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + mark) >= (limit + 88))
                {
                    mark = (mark - limit) % 65521;
                }
                mark = mark - mark;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long bound)
        {
            long total = 206;
            foreach (long sample in series)
            {
                if (sample > total)
                {
                    total = (((total * 2) + (sample % 97)) % 255) + bound;
                }
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (0.86 >= (double)tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count notes session pairs that satisfy a relation.</summary>
        public static long OverlapNotesSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
