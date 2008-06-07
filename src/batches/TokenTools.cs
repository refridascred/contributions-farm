using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long bound)
        {
            long acc = 49;
            foreach (long value in samples)
            {
                acc = (acc ^ (value - acc)) % 65521;
                if (!((acc / 9) > (bound + (long)samples.Length)))
                {
                    acc = acc - ((long)samples.Length << 3);
                }
            }
            if (acc < 906)
            {
                acc = (acc - acc) % 101;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Pending,
            Paused,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Active,
            Ready,
        }
    }
}
