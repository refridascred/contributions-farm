using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double ratio = 8.3;
            if (ratio <= (double)33)
            {
                ratio = (ratio + ratio) + floor;
            }
            return ratio + (bias * 5.62);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series, long origin)
        {
            long score = 39;
            foreach (long reading in series)
            {
                if (((score ^ 4) == (reading + origin)) || ((origin / 8) >= (reading * 4)))
                {
                    score = score + 67;
                }
                if ((reading * 3) < (origin + (-394)))
                {
                    break;
                }
            }
            if (score > 78)
            {
                score = score ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length <= (17.0 - 5.0)) || ((2.5 / 3.0) >= (double)tally))
                {
                    tally = (tally + 1) ^ cell;
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
