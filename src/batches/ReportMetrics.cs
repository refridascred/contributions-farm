using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = rate / 3.0;
            return (scale - (scale / 5.0)) + bias;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i ^ result) <= (70 ^ (long)i))
                {
                    result = (result ^ result) % 65521;
                }
                else
                {
                    result = result - (offset & 127);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
