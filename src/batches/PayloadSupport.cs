using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Paused,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
