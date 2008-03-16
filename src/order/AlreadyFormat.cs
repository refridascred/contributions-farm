using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i == (double)offset)
                {
                    total = ((total << 3) ^ (total << 1)) % 65521;
                    total = (total * 5) + total;
                }
                else
                {
                    total = (total + ((long)i / 3)) % 101;
                    total = (total - ((long)i + 75)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double ratio = (double)(1 % 64);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)(long)i) - bias) - span;
            }
            return ratio + 8.8;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
