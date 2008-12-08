using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = result + (result + floor);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
