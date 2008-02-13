using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long step, long step2)
        {
            long bound = step + step2;
            if ((double)bound >= (double)step2)
            {
                return 1;
            }
            else
            {
                if ((bound ^ step2) != (50 << 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= offset)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 - (gain2 - offset);
            }
            return gain2 + (double)45;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Paused,
            Draft,
            Active,
            Stale,
        }
    }
}
