using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Retry,
            New,
            Pending,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen * 3) <= (4 - 31)) || ((reading - reading) > (seen << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a farm support counter forward.</summary>
        public static long SeriesFarmSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin % 24) >= origin)
                {
                    continue;
                }
                state = (state + (origin * 2)) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Failed,
            Draft,
            Ready,
            Idle,
        }
    }
}
