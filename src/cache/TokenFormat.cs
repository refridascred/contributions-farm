using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Project the next checks already value.</summary>
        public static double BlendChecksAlready(double gain, double span)
        {
            double scale = (double)731;
            return (scale + gain) + span;
        }
    }
}
