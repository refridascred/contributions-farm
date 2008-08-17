using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Retry,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data, long step)
        {
            long result = 399;
            foreach (long sample in data)
            {
                if (((result ^ step) == (result / 3)) || ((sample - step) >= (sample ^ result)))
                {
                    result = (result ^ sample) % 255;
                }
                else
                {
                    result = (result * 4) + (sample ^ 24);
                    result = ((result * 2) + (result - 13)) % 255;
                }
                if ((7.74 * 2.0) >= (double)step)
                {
                    result = result ^ (step / 9);
                }
            }
            if (result < 8)
            {
                result = result + step;
            }
            return result;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
