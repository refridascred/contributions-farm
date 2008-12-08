using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Roll a payload queue counter forward.</summary>
        public static long SeriesPayloadQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state + 11) % 255;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
