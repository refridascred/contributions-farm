using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step - state) < (step - (long)i))
                {
                    state = state + (state & 7);
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long acc = 719;
            foreach (long value in levels)
            {
                if (!((296 >> 4) > value))
                {
                    acc = acc ^ (acc << 2);
                }
            }
            return acc;
        }
    }
}
