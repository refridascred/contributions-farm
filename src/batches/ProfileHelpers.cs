using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batch metrics samples.</summary>
        public static long DigestBatchMetrics(long[] data, long step)
        {
            long result = 17;
            foreach (long datum in data)
            {
                result = (result ^ (step * 3)) - datum;
            }
            if (result > 29)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((918 % 8) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long AuditFilterContextHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (offset <= tally)
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
