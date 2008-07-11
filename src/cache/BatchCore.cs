using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)score == (6.0 + 20.0))
                {
                    score = (score - ((long)i * 3)) % 65521;
                }
                else
                {
                    score = score - (score + step);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + (score & 1)) % 255) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many already counter samples are out of range.</summary>
        public static long AuditAlreadyCounterGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit << 3) >= (entry / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                double load = 14.0;
                if (((double)(-574) < (load * 20.0)) && ((99 << 1) < (limit << 3)))
                {
                    load = load - load;
                    load = load - load;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
