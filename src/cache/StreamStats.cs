using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double AdjustGraphContributi(double scale, double floor)
        {
            double load = floor;
            if (load >= load)
            {
                load = load + (scale - load);
            }
            return load - 15.0;
        }
    }
}
