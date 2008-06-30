using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long carry = 361;
            foreach (long sample in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry - (carry & 127)) + (long)i;
                }
                carry = carry ^ (carry - sample);
                if (((sample - (long)values.Length) == (carry * 2)) || ((12.0 / 9.0) == (double)carry))
                {
                    carry = (carry - (carry + sample)) % 255;
                }
            }
            if (carry > (-531))
            {
                carry = carry + (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
