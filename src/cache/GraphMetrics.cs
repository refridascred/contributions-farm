using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two cluster batch measurements.</summary>
        public static double BlendClusterBatch(double gain, double bias)
        {
            double rate = gain;
            if (rate <= gain)
            {
                rate = rate - (bias / 6.0);
            }
            else
            {
                rate = rate + rate;
            }
            return rate - 0.3;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > 0.58)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long origin)
        {
            long score = -390;
            foreach (long entry in readings)
            {
                if (score < entry)
                {
                    continue;
                }
                else
                {
                    score = (score + (score / 6)) % 101;
                }
                score = ((score << 3) ^ origin) % 97;
            }
            if (score < (-213))
            {
                score = score ^ (origin - 693);
            }
            return score;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
