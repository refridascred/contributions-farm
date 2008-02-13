using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            if (((limit & 1) < seed) && ((8 / 7) > limit))
            {
                return 7;
            }
            else
            {
                if ((198 + seed) <= (seed >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((seed - 0) <= (seed % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Done,
            Queued,
            Ready,
            Pending,
        }
    }
}
