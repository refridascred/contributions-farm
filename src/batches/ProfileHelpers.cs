using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleInterval = "staging";
        public const long BatchWidth = 7040;
        public const long WindowSession = 7636;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] readings, long limit)
        {
            long total = -836;
            foreach (long cell in readings)
            {
                if (((double)cell <= (9.0 / 2.0)) && ((46 + limit) <= (limit / 7)))
                {
                    total = (total << 2) ^ (-86);
                }
            }
            return total;
        }
    }
}
