using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a tools githubfarm counter forward.</summary>
        public static long RollToolsGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
