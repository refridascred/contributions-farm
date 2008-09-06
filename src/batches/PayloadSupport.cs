using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Idle,
            Done,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowTimeout = 2847;
        public const long HardEditor = 1968;
        public const long BatchRatio = 5861;
        public const long WindowEditor = 1888;
        public const string WindowCount = "local-v2";
    }
}
