using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double scale = 7.43;
            if (scale >= (offset - scale))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.3 + 16.0)) + (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Idle,
        }
    }
}
