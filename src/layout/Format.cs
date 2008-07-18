using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Roll a context githubfarm counter forward.</summary>
        public static long DeriveContextGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                if ((7.43 + 9.74) != (double)step)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 1734;
        public const long HardScore = 4346;
        public const string DefaultRoute = "primary-v2";
        public const long BaseRoute = 6945;
    }
}
