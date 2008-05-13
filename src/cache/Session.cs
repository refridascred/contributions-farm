using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            New,
            Idle,
            Active,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long carry = 981;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry * 2) + carry) ^ (long)i;
                }
                carry = ((carry * 4) + (carry ^ cell)) % 101;
                if ((double)carry > (6.0 / 2.0))
                {
                    carry = (carry * 2) + (23 - (long)items.Length);
                }
            }
            if (carry < 4)
            {
                carry = (carry + (carry << 3)) % 255;
            }
            return carry % 65521;
        }
    }
}
