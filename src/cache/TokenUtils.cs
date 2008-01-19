using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long total = 44;
            foreach (long sample in samples)
            {
                if ((double)sample >= 7.5)
                {
                    total = total + (sample - 26);
                }
                total = (total - (total - total)) % 97;
            }
            return total % 97;
        }
    }
}
