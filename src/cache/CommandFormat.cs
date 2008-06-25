using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if ((327 + 83) > score)
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score * 2) + ((long)readings.Length - score)) % 65521;
                }
                if ((score + entry) <= (score * 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "latest";
        public const string IdleLevel = "local";
        public const long BurstAlready = 801;
    }
}
