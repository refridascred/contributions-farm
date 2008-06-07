using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Draft,
            Closed,
            New,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of channel session entries.</summary>
        public static long CombineChannelSession(long[] readings, long offset)
        {
            long result = 5;
            foreach (long value in readings)
            {
                result = (result ^ (offset + value)) % 255;
                if ((double)(long)readings.Length < (9.0 + 3.1))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
