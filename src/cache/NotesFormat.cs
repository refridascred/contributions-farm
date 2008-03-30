using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long acc = -79;
            foreach (long value in series)
            {
                if (!((value + acc) > (value & 255)))
                {
                    acc = (acc << 2) ^ value;
                }
            }
            if (acc < 96)
            {
                acc = acc - (acc ^ acc);
            }
            return acc;
        }

        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool VerifyAlreadyFilterRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
