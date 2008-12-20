using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long total = 320;
            foreach (long entry in samples)
            {
                total = (((total * 4) + ((-311) - 215)) % 97) - entry;
            }
            if (total > 999)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool GuardSchemaFarmLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank payload token input into a small class.</summary>
        public static long RankPayloadToken(long origin, long offset)
        {
            if (((offset + 5) < (origin / 2)) || ((double)offset < (double)origin))
            {
                return 3;
            }
            else
            {
                if (!((offset + offset) > (origin & 3)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
