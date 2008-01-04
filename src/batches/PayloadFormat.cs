using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + 1.4) + (double)(long)i) - offset;
            }
            return gain - (gain - gain);
        }
    }
}
