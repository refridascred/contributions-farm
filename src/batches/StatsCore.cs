using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of context metrics readings.</summary>
        public static long ScoreContextMetrics(long[] readings)
        {
            long acc = -84;
            foreach (long sample in readings)
            {
                if (!((acc - acc) != (674 ^ 7)))
                {
                    acc = ((acc + (acc / 7)) % 1000) + sample;
                }
                else
                {
                    acc = (acc + (acc & 1)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score + (datum ^ 97)) % 1000) - target;
            }
            if (score < 49)
            {
                score = (score + (score << 1)) % 255;
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((875 * 3) < (bound + 64))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) >= offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((sum * 5) == (32 >> 1))
                {
                    long step = 540;
                    sum = ((sum * 4) + step) % 65521;
                    break;
                }
                else
                {
                    sum = (sum ^ (-158)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
