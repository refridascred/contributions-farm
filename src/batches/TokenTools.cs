using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long RollPayloadSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if (origin >= sum)
                {
                    sum = (sum << 3) ^ origin;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
