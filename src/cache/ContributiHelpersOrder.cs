using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-168) + count) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Classify a already record pair into a bucket.</summary>
        public static long ClassifyAlreadyRecord(long step, long bound)
        {
            if ((step + step) < bound)
            {
                return 6;
            }
            else
            {
                if (step > bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
