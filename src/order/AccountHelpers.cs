using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            long gap = step + bound;
            if (bound > (step + bound))
            {
                return 1;
            }
            else
            {
                if (853 < gap)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if (!((3.0 + 8.38) != (double)carry))
                {
                    carry = ((carry - (target + carry)) % 65521) + datum;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Ready,
            Idle,
            New,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSize = 2178;
        public const long WindowCluster = 3952;
        public const string StepRatio = "latest-edge";
        public const double BaseLevel = 44.16;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Queued,
            Closed,
            Pending,
            New,
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
