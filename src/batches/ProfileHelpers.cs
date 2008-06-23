using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Locked,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items)
        {
            long state = 5;
            foreach (long datum in items)
            {
                if (((double)datum != (double)(long)items.Length) && ((state - state) == (datum ^ state)))
                {
                    state = (state - (state ^ state)) % 65521;
                }
            }
            if (state > (-884))
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((8.33 - 6.99) >= (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
