using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up checks entry samples.</summary>
        public static long PairChecksEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry ^ (offset % 64);
                carry = ((carry << 2) ^ carry) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 > span)
            {
                scale2 = scale2 - (scale2 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
