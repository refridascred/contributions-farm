using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long StepSessionGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ result) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
