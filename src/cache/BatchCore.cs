using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Locked,
            Done,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                }
                if ((686 > bound) || (bound <= score))
                {
                    score = score ^ (bound ^ 8);
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (long)i) % 101;
                }
                score = (score << 2) ^ (bound & 255);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
