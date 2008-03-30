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

        /// <summary>Derive the next command report value from a seed.</summary>
        public static long StepCommandReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 3) ^ (limit - limit)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
