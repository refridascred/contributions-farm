using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of record command readings.</summary>
        public static long WeighRecordCommand(long[] levels, long origin)
        {
            long score = 28;
            foreach (long entry in levels)
            {
                if ((score & 31) < (614 + origin))
                {
                    score = score - entry;
                }
                if ((34 >= origin) && ((origin + score) <= (score ^ score)))
                {
                    score = ((score * 5) + 188) % 65521;
                }
                if ((score << 3) < (origin << 3))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
