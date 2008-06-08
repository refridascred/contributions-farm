using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - tally) != ((long)values.Length + tally)) && (((double)80 == (double)sample) || ((tally + tally) <= tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long DeriveProfileContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!((6.96 - 0.71) <= (double)offset))
                {
                    result = result - (offset - result);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string LimitSupport = "fallback-1";
        public const string DefaultSupport = "alpha-v2";
    }
}
