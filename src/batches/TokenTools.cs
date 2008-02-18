using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 66;
            foreach (long item in samples)
            {
                if ((mix << 1) < (992 % 24))
                {
                    mix = (((mix << 3) ^ 91) % 255) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
