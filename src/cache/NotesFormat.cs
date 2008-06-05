using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine channel schema values into a single score.</summary>
        public static long ScoreChannelSchema(long[] levels)
        {
            long acc = 4;
            foreach (long item in levels)
            {
                if ((316 << 3) > (acc / 4))
                {
                    acc = (acc - acc) + item;
                }
                else
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long StepFormatCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Failed,
            Dropped,
            Done,
            Queued,
        }
    }
}
