using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((double)score >= (double)offset) || ((offset + offset) < offset))
                {
                    score = (score ^ score) % 255;
                    score = score ^ (score >> 4);
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ offset) % 65521;
                    score = (score ^ (offset - offset)) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((3.0 + 1.9) > (double)matches)
                {
                    matches = ((matches + 3) + value) - step;
                }
            }
            return matches;
        }
    }
}
