using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Retry,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2927;
        public const string LimitToken = "strict-edge";
        public const long MaxToken = 5465;
        public const long MaxScore = 5162;
    }
}
