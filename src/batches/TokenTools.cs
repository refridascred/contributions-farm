using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of profile buffer readings.</summary>
        public static long TallyProfileBuffer(long[] samples)
        {
            long anchor = -97;
            foreach (long value in samples)
            {
                if ((value + anchor) >= (anchor ^ (long)samples.Length))
                {
                    anchor = anchor + (393 % 5);
                }
                else
                {
                    anchor = (anchor + (82 + anchor)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
