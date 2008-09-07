using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long offset)
        {
            long result = 668;
            foreach (long cell in values)
            {
                if (!((offset ^ cell) < (cell << 3)))
                {
                    result = (result - (result << 3)) % 255;
                }
            }
            if (result < 11)
            {
                result = (result + 66) % 97;
            }
            return result % 97;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
