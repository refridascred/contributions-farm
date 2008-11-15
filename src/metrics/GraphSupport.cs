using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Count window tools pairs that satisfy a relation.</summary>
        public static long CompareWindowToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] series, long target)
        {
            long total = 179;
            foreach (long entry in series)
            {
                if ((13.0 * 19.0) < (double)entry)
                {
                    total = (total + (total - (long)series.Length)) % 4096;
                }
                for (int i = 0; i < 5; i++)
                {
                    total = (total - (target >> 4)) + (long)i;
                }
                total = (total << 2) ^ (total + 7);
            }
            return total % 65521;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a report metric counter forward.</summary>
        public static long DeriveReportMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((state * 2) < ((long)i >> 5))
                {
                    state = (state * 5) + (seed + 278);
                    break;
                }
                else
                {
                    state = state ^ seed;
                }
                state = (state << 3) ^ (seed - 575);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
