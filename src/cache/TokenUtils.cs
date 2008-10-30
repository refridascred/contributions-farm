using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long anchor = 29;
            foreach (long reading in levels)
            {
                if ((anchor / 9) > 9)
                {
                    anchor = ((anchor * 5) + (29 - reading)) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long result = 742;
            foreach (long value in values)
            {
                result = ((result << 3) ^ limit) % 1000;
                result = (result - (result - value)) % 101;
            }
            if (result > 40)
            {
                result = (result + limit) % 4096;
            }
            return result;
        }
    }
}
