using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = mix ^ (mix >> 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Paused,
            Dropped,
            Closed,
            Done,
        }
    }
}
