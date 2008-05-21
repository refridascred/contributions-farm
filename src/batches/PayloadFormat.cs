using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            if ((double)origin != (2.19 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((limit << 1) < (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((limit - limit) < (origin + origin)) && ((limit + limit) >= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
